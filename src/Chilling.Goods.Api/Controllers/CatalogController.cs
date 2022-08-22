using Chilling.Goods.Api.Models;
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
        //TODO: раскометить после добавления реализации
        //private readonly ICatalogService _service;
        //private readonly IMapper _mapper;

        //public CatalogController(ICatalogService service, IMapper mapper)
        //{
        //    _service = service;
        //    _mapper = mapper;

        // }

        /// <summary>
        /// Получить все каталоги 
        /// </summary>
        /// <returns>Список каталогов</returns>
        [HttpGet("")]
        public async Task<ActionResult<List<CatalogVm>>> GetAllAsync()
        {
            //var response = await _service.GetAllAsync();

            //var result = _mapper.Map<>(response);

            //return Ok(result);

            throw new NotImplementedException();
        }

        [HttpPost("")]
        public async Task<ActionResult<List<CatalogVm>>> AddAsync([FromBody] CatalogVm catalog)
        {
            throw new NotImplementedException();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync([FromBody] CatalogVm catalog, Guid id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}