using System.Text.Json.Serialization;

namespace Chilling.Goods.Api.Models;

public class TagVm
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название тэга
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }
}