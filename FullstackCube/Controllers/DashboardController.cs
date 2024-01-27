using FullstackCube.Data;
using FullstackCube.Models;
using Microsoft.AspNetCore.Mvc;

namespace FullstackCube.Controllers
{
    [Route("api/dashboards/participantes")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public readonly DashboardContext _dashboardContext;
        public DashboardController(DashboardContext dashboardContext)
        {
            _dashboardContext = dashboardContext;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var participantes = _dashboardContext.Participantes.ToList();
            return Ok(participantes);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Participante participante)
        {
            _dashboardContext.Participantes.Add(participante);
            _dashboardContext.SaveChanges();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            var participanteDb = _dashboardContext.Participantes.Where(x => x.Id == id).FirstOrDefault();

            if (participanteDb is null)
            {
                return NotFound("Participante não encontrado :(");
            }

            _dashboardContext.Participantes.Update(participanteDb);
            _dashboardContext.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var participanteDb = _dashboardContext.Participantes.Where(x => x.Id == id).FirstOrDefault();

            if (participanteDb is null)
            {
                return NotFound("Participante não encontrado :(");
            }

            _dashboardContext.Participantes.Remove(participanteDb);
            _dashboardContext.SaveChanges();
            return Ok();
        }
    }
}
