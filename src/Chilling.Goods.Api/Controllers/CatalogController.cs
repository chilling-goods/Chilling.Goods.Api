using Chilling.Goods.Api.Core.Interfaces;
using Chilling.Goods.Api.Core.Models;
using Chilling.Goods.Api.Models;
using Chilling.Platform.Mapper.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Chilling.Goods.Api.Controllers
{
    /// <summary>
    /// Каталог контроллер
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogService _service;
        private readonly IMapper _mapper;

        /// <summary>
        /// Контроллер
        /// </summary>
        /// <param name="service"></param>
        /// <param name="mapper"></param>
        public CatalogController(ICatalogService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        /// <summary>
        /// Получить все каталоги 
        /// </summary>
        /// <returns>Список каталогов</returns>
        [HttpGet("")]
        public async Task<ActionResult<List<CatalogVm>>> GetAllAsync(CancellationToken cancellationToken)
        {
            var response = await _service.GetAllAsync(cancellationToken);

            var result = _mapper.Map<Catalog, CatalogVm>(response).ToList();

            return result;
        }

        [HttpPost("")]
        public async Task<ActionResult<List<CatalogVm>>> AddAsync([FromBody] CatalogVm catalog, CancellationToken cancellationToken)
        {
            var mapResult = _mapper.Map<CatalogVm, Catalog>(catalog);
            await _service.AddAsync(mapResult, cancellationToken);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync([FromBody] CatalogVm catalog, Guid id, CancellationToken cancellationToken)
        {
            var mapResult = _mapper.Map<CatalogVm, Catalog>(catalog);
            await _service.UpdateAsync(mapResult, id, cancellationToken);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _service.DeleteAsync(id, cancellationToken);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> ClearCacheAsync(CancellationToken cancellationToken)
        {
            await _service.СlearCacheAsync(cancellationToken);
            return NoContent();
        }
    }
}