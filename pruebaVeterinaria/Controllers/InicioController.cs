using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace pruebaVeterinaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InicioController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("Servicio Levantado " + Assembly.GetExecutingAssembly().GetName().Name + " - versión N° " + Assembly.GetExecutingAssembly().GetName().Version);

        }
    }
}
