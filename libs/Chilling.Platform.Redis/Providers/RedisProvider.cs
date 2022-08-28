using StackExchange.Redis;
using System.Text;
using System.Text.Json;

namespace Chilling.Platform.Redis.Providers;

public class RedisProvider : IRedisProvider
{
    private readonly IDatabase _database;
    private const int DefaultCacheLifetime = 8;

    public RedisProvider(IDatabase database)
    {
        _database = database;
    }

    public async Task<T> GetAsync<T>(string cacheKey)
    {
        var data = await _database.StringGetAsync(cacheKey);
        if ((byte[])data is null)
            return default;
        var encodedData = Encoding.UTF8.GetString(data);
        return JsonSerializer.Deserialize<T>(encodedData);
    }

    public async Task SetAsync<T>(string cacheKey, T data, int? lifeTime = null)
        where T : class
    {
        var stringData = JsonSerializer.Serialize(data);
        var a = DateTime.Now.AddHours(1);
        var resultData = Encoding.UTF8.GetBytes(stringData);
        if (lifeTime is null)
            lifeTime = DefaultCacheLifetime;
        await _database.StringSetAsync(cacheKey, resultData, TimeSpan.FromHours(lifeTime.Value));
    }

    public async Task<bool> RemoveAsync(string cacheKey)
    {
        return await _database.KeyDeleteAsync(cacheKey);
    }
}