using ItemCatalogue.Api.Application.Interfaces;
using ItemCatalogue.Api.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ItemCatalogue.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ICatalogueService _catalogueService;

        public ItemsController(ICatalogueService catalogueService)
        {
            _catalogueService = catalogueService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllItems()
        {
            var catalogues = await _catalogueService.GetAllItemsAsync();

            return Ok(catalogues);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be greater than 0.");
            }

            var catalogue = await _catalogueService.GetItemByIdAsync(id);

            return Ok(catalogue);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem([FromBody] CreateItemRequest request)
        {
            var catalogueId = await _catalogueService.CreateItemAsync(request);

            return Ok(catalogueId);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateById(int id, [FromBody] UpdateItemRequest request)
        {
            if (id <= 0)
            {
                return BadRequest("Id must be greater than 0.");
            }

            await _catalogueService.UpdateItemAsync(id, request);

            return NoContent();
        }
    }
}
