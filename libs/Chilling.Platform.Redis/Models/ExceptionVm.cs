using System.Text.Json.Serialization;

namespace Chilling.Platform.Redis.Models;

public class ExceptionVm
{
    [JsonPropertyName("code")]
    public int StatusCode { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }
}