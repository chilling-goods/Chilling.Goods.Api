using System.Net;
using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Chilling.Goods.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BrandController: ControllerBase
{
    private readonly IBrandService _brandService;
    private readonly IMapper _mapper;

    public BrandController(IBrandService brandService, IMapper mapper)
    {
        _brandService = brandService;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Получение списка брендов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType( typeof(IEnumerable<BrandVm>), 200)]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
    {
        var data = await _brandService.GetAsync(cancellationToken);
        var result = _mapper.Map<Brand, BrandVm>(data);
        return Ok(result);
    }

    /// <summary>
    /// Добавление модели
    /// </summary>
    /// <param name="brand"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddAsync(BrandVm brand, CancellationToken cancellationToken)
    {
        var mappedData = _mapper.Map<BrandVm, Brand>(brand);
        await _brandService.AddAsync(mappedData, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Обновление модели бренда
    /// </summary>
    /// <param name="id"></param>
    /// <param name="brand"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPatch("{id}")]
    public async Task<IActionResult> UpdateAsync(string id, [FromBody] BrandVm brand, CancellationToken cancellationToken)
    {
        var data = _mapper.Map<BrandVm, Brand>(brand);
        var guid = Guid.Parse(id);
        await _brandService.UpdateAsync(guid, data, cancellationToken);
        return NoContent();
    }

    /// <summary>
    /// Удаление модели
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(string id, CancellationToken cancellationToken)
    {
        var guid = Guid.Parse(id);
        await _brandService.DeleteAsync(guid, cancellationToken);
        return NoContent();
    }
}