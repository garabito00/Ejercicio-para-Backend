using Directorio.AppService.Servicios.Interfaz;
using Directorio.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directorio.API.Controllers
{
    [Route("api/directorio")]
    [ApiController]
    public class DirectorioController : ControllerBase
    {
        private readonly IDirectorioServicio servicio;

        public DirectorioController(IDirectorioServicio _servicio)
        {
            servicio = _servicio;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetDirectorios()
        {
            try
            {
                var directorio = await servicio.GetDirectorio();
                return directorio.ToList();
            }
            catch (Exception e)
            {
                return StatusCode(404, new { Mensaje = e.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Persona>> GetRegistro(int id)
        {
            try
            {
                var registro = await servicio.GetUnRegistro(id);
                return registro;
            }
            catch (Exception e)
            {
                return StatusCode(404, new { Mensaje = e.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarUnRegistro(Persona persona)
        {
            await servicio.AgregarUnRegistroAlDirectorio(persona);
            return StatusCode(201, new { Mensaje = "Se inserto el registro en la base de datos" }); ;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> BorrarRegistro(int id)
        {
            try
            {
                await servicio.BorrarUnRegistro(id);
                return StatusCode(200, new { Mensaje = "Se borro el registro de la base de datos" });
            }
            catch (Exception e)
            {
                return StatusCode(404, new { Mensaje = e.Message });
            }
        }
    }
}
