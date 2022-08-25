using Chilling.Platform.Redis;
using Microsoft.AspNetCore.Mvc;

namespace Chilling.Goods.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController: ControllerBase
{
    private readonly IRedisProvider _redisProvider;

    public TestController(IRedisProvider redisProvider)
    {
        _redisProvider = redisProvider;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync([FromQuery] string  key)
    {
        return Ok(await _redisProvider.GetAsync<TestRedisModel>(key));
    }

    [HttpPost]
    public async Task<IActionResult> SetAsync([FromQuery] string key, [FromBody] TestRedisModel data)
    {
        await _redisProvider.SetAsync(key, data);
        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAsync([FromQuery] string key)
    {
        return Ok(await _redisProvider.RemoveAsync(key));
    }
}

public class TestRedisModel
{
    public string Name { get; set; }

    public int Numner { get; set; }
}