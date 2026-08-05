// =============================================================================
// SenacGames.API - UsuariosController.cs
// =============================================================================

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SenacGames.Application.DTOs;
using SenacGames.Application.Interfaces;

namespace SenacGames.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Requer autenticação por padrão
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuariosService _usuariosService;

        public UsuariosController(IUsuariosService usuariosService)
        {
            _usuariosService = usuariosService;
        }

        /// <summary>
        /// Retorna a lista de todos os usuários.
        /// GET /api/usuarios
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
        {
            var usuarios = await _usuariosService.GetAllAsync();
            return Ok(usuarios);
        }

        /// <summary>
        /// Retorna um usuário específico pelo ID.
        /// GET /api/usuarios/{id}
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioDto>> GetById(string id)
        {
            var usuario = await _usuariosService.GetByIdAsync(id);
            if (usuario == null) return NotFound(new { message = "Usuário não encontrado." });
            return Ok(usuario);
        }

        /// <summary>
        /// Cria um novo usuário.
        /// POST /api/usuarios
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<UsuarioDto>> Create([FromBody] CreateUsuarioDto dto)
        {
            var (success, usuario, error) = await _usuariosService.CreateAsync(dto);
            if (!success) return BadRequest(new { message = error });
            
            return CreatedAtAction(nameof(GetById), new { id = usuario!.Id }, usuario);
        }

        /// <summary>
        /// Atualiza um usuário existente.
        /// PUT /api/usuarios/{id}
        /// </summary>
        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioDto>> Update(string id, [FromBody] UpdateUsuarioDto dto)
        {
            var (success, usuario, error) = await _usuariosService.UpdateAsync(id, dto);
            if (!success) return BadRequest(new { message = error });
            
            return Ok(usuario);
        }

        /// <summary>
        /// Exclui um usuário.
        /// DELETE /api/usuarios/{id}
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var (success, error) = await _usuariosService.DeleteAsync(id);
            if (!success) return BadRequest(new { message = error });
            
            return NoContent();
        }

        /// <summary>
        /// Retorna a lista de perfis disponíveis.
        /// GET /api/usuarios/perfis
        /// </summary>
        [HttpGet("perfis")]
        public async Task<ActionResult<IEnumerable<string>>> GetPerfis()
        {
            var perfis = await _usuariosService.GetPerfisAsync();
            return Ok(perfis);
        }
    }
}
