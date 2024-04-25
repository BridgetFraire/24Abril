using System;

namespace Abril24.ITD.PERROSPERDIDOS.API.CONTROLLERS
{
    public class MyControllerBase : ControllerBase
    {
        
        protected IActionResult HandleError(Exception ex, int statusCode)
        {
            switch (statusCode)
            {
                case StatusCodes.Status200OK:
                    return Ok(new { message = "La solicitud se procesó correctamente" });
                case StatusCodes.Status400BadRequest:
                    return BadRequest(new { message = "Se produjo un error debido a una entrada incorrecta o insuficiente" });
                case StatusCodes.Status401Unauthorized:
                    return Unauthorized(new { message = "El usuario que realiza la solicitud no tiene permisos" });
                case StatusCodes.Status500InternalServerError:
                    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Se produjo un error interno en el servidor al procesar la solicitud." });
                default:
                    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Ocurrió un error desconocido." });
            }
        }
    }
}