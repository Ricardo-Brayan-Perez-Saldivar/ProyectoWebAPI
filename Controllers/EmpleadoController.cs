using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProyectoWebAPI.Data;
using ProyectoWebAPI.Models;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly EmpleadoData _empleadoData;

        public EmpleadoController(EmpleadoData empleadoData)
        {
            _empleadoData = empleadoData;
        }

        [HttpGet("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Empleado> Lista = await _empleadoData.Lista();
            return StatusCode(StatusCodes.Status200OK,Lista);
        }

        [HttpPost("Crear")]
        public async Task<IActionResult> Crear([FromBody] Empleado objeto)
        {
            bool res = await _empleadoData.Crear(objeto);
            return StatusCode(StatusCodes.Status200OK, new {isSuccess = res});
        }

        [HttpPut("Editar")]
        public async Task<IActionResult> Editar([FromBody] Empleado objeto)
        {
            bool res = await _empleadoData.Modificar(objeto);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = res });
        }

        [HttpDelete("Eliminar")]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool res = await _empleadoData.Eliminar(id);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = res });
        }
        
        [HttpPost("Busqueda")]
        public async Task<IActionResult> Busqueda(int id)
        {
            List<Empleado> Lista = await _empleadoData.Busqueda(id);
            return StatusCode(StatusCodes.Status200OK, Lista);
        }

    }
}
