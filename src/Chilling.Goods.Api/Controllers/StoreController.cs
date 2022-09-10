using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chilling.Goods.Api.Controllers;

/// <summary>
/// Контроллер магазинов
/// </summary>
[ApiController]
[Route("[controller]")]
public class StoreController : ControllerBase
{
    private readonly IStoreService _storeService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="storeService"></param>
    /// <param name="mapper"></param>
    public StoreController(IStoreService storeService, IMapper mapper)
    {
        _storeService = storeService;
        _mapper = mapper;
    }

    /// <summary>
    /// Получение списка всех магазинов
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<IEnumerable<StoreVm>>> GetAllAsync(CancellationToken cancellationToken)
    {
        var result = await _storeService.GetAllAsync(cancellationToken);
        return Ok(_mapper.Map<IEnumerable<BaseEntity>, IEnumerable<BaseEntityVm>>(result));
    }

    /// <summary>
    /// Получение магазина по id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}")]
    public async Task<ActionResult<IEnumerable<StoreVm>>> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _storeService.GetByIdAsync(id, cancellationToken);
        return Ok(_mapper.Map<Store, StoreVm>(result));
    }

    /// <summary>
    /// Добавление магазина
    /// </summary>
    /// <param name="store"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddAsync(StoreVm store, CancellationToken cancellationToken)
    {
        var request = _mapper.Map<StoreVm, Store>(store);
        var result = await _storeService.AddAsync(request, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Обновление магазина
    /// </summary>
    /// <param name="store"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPatch]
    public async Task<IActionResult> UpdateAsync(StoreVm store, Guid id, CancellationToken cancellationToken)
    {
        var request = _mapper.Map<StoreVm, Store>(store);
        await _storeService.UpdateAsync(request, id, cancellationToken);
        return NoContent();
    }
    
    /// <summary>
    /// Удаление магазина
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _storeService.DeleteAsync(id, cancellationToken);
        return NoContent();
    }
}