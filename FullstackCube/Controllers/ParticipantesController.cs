using FullstackCube.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullstackCube.Controllers
{
    [Route("api/participantes")]
    [ApiController]
    public class ParticipantesController : ControllerBase
    {
        public ParticipantesController()
        {
            
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var participante = new Participante();
            participante.Id = 1;
            participante.FirstName = "Calebe";
            participante.LastName = "Martins";
            participante.Participation = 5;

            return Ok(participante);
        }
    }
}
