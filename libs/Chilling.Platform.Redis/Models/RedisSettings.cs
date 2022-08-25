namespace Chilling.Platform.Redis.Models;

/// <summary>
/// Настройки Redis
/// </summary>
public class RedisSettings
{
    /// <summary>
    /// Строка подключения к Redis
    /// </summary>
    public string ConnectionString { get; set; }
}