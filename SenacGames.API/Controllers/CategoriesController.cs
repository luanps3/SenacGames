// =============================================================================
// SenacGames.API - CategoriesController
// =============================================================================
// Controller REST para operações com Categorias.
//
// Endpoints:
// GET    /api/categories        Lista todas as categorias
// POST   /api/categories        Cria uma nova categoria
// PUT    /api/categories/{id}   Atualiza uma categoria
// DELETE /api/categories/{id}   Remove uma categoria
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Retorna todas as categorias.
        /// GET /api/categories
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        /// <summary>
        /// Cria uma nova categoria.
        /// POST /api/categories
        /// </summary>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CategoryDto>> Create([FromBody] CreateCategoryDto dto)
        {
            var category = await _categoryService.CreateAsync(dto);
            return CreatedAtAction(nameof(GetAll), new { id = category.Id }, category);
        }

        /// <summary>
        /// Atualiza uma categoria existente.
        /// PUT /api/categories/{id}
        /// </summary>
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CategoryDto>> Update(int id, [FromBody] UpdateCategoryDto dto)
        {
            var category = await _categoryService.UpdateAsync(id, dto);

            if (category == null)
                return NotFound(new { message = "Categoria não encontrada." });

            return Ok(category);
        }

        /// <summary>
        /// Remove uma categoria.
        /// DELETE /api/categories/{id}
        /// </summary>
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _categoryService.DeleteAsync(id);

            if (!deleted)
                return NotFound(new { message = "Categoria não encontrada." });

            return NoContent();
        }
    }
}
