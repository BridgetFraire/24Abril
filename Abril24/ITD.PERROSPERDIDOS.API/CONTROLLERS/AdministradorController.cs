using System;
using Abril24.ITD.PERROSPERDIDOS.APPLICATION.SERVICES;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Java.Lang;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Mime;

using Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;

namespace Abril24.ITD.PERROSPERDIDOS.API.CONTROLLERS
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {
        private readonly AdministradorService _administradorService;

        public AdministradorController(AdministradorService administradorService)
        {
            _administradorService = administradorService;
        }
    public class MascotaPerdidaController : ControllerBase
    {
        private readonly MascotaPerdidaService _mascotaPerdidaService;

        public MascotaPerdidaController(MascotaPerdidaService mascotaPerdidaService)
        {
             _mascotaPerdidaService = mascotaPerdidaService;
        }
            // ------------------------------------PROCEDIMIENTO POST-----------------------------------------

            [HttpPost]
            public async Task<IActionResult> Post([FromBody] MascotaPerdida mascotaPerdida)
            {
                var result = await _mascotaPerdidaService.ReportarPerroPerdido(mascotaPerdida.IdUsuario, mascotaPerdida.Celular, mascotaPerdida.Raza, mascotaPerdida.Color, mascotaPerdida.Tamano, mascotaPerdida.Sexo, mascotaPerdida.Caracteristicas, mascotaPerdida.FechaVisto, mascotaPerdida.LugarVisto, mascotaPerdida.Imagen);
                if (result > 0)
                {
                    return Ok(new { message = "El reporte del perro perdido se ha creado correctamente." });
                }
                else
                {
                    return BadRequest(new { message = "Ocurrió un error al crear el reporte del perro perdido." });
                }
            }

            // ------------------------------------PROCEDIMIENTO PATCH-----------------------------------------
            [HttpPatch("{id}")]
            public async Task<IActionResult> Patch(int id, [FromBody] MascotaPerdida mascotaPerdida)
            {
                var result = await _mascotaPerdidaService.ModificarCaracteristicasPerroPerdido(id, mascotaPerdida.Caracteristicas);
                if (result > 0)
                {
                    return Ok(new { message = "Las características del perro perdido se han modificado correctamente." });
                }
                else
                {
                    return BadRequest(new { message = "Ocurrió un error al modificar las características del perro perdido." });
                }
            }
            // ------------------------------------PROCEDIMIENTO GET-----------------------------------------
            [HttpGet]

            public async Task<IActionResult> Get()
            {
                var result = await _mascotaPerdidaService.ObtenerPublicacionesRecientes();
                if (result.Any())
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound(new { message = "No se encontraron publicaciones recientes." });
                }
            }
        }
    }
}