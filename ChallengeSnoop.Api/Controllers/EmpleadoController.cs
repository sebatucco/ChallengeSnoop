using ChallengeSnopp.Core.DTOs;
using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeSnoop.Api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _empleadoService.GetAllAsync();
            return Ok(response);
        }

        [HttpGet("/{Id}")]
        public async Task<IActionResult> GetById([FromRoute]int Id)
        {
            var response = await _empleadoService.GetByIdAsync(Id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EmpleadoDTO empleado)
        {
            var response = await _empleadoService.Add(empleado);
            return Ok(response);
        }

        [HttpPut]

        public async Task<IActionResult> Put([FromBody] Empleado empleado)
        {
            var response = await _empleadoService.Update(empleado);
            return Ok(response);
        }

        [HttpGet("AntiguedadEmpleado/{AnioRomano}")]
        public async Task<IActionResult> GetAntiguedadEmpleado([FromRoute] string AnioRomano)
        {
            var response = await _empleadoService.AntiguedadEmpleado(AnioRomano);
            return Ok(response);
        }

    }
}
