using Chilling.Goods.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chilling.Goods.Api.Controllers;

/// <summary>
/// Контроллер брендов
/// </summary>
[ApiController]
[Route("[controller]")]
public class BrandsController:ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<BrandVm>> GetBrandsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> AddBrandAsync([FromBody] BrandVm brand)
    {
        throw new NotImplementedException();
    }

    [HttpPatch]
    public async Task UpdateBrandAsync(string id)
    {
        throw new NotImplementedException();
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteBrandAsync(string id)
    {
        throw new NotImplementedException();
    }
}