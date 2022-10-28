using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto01.Application.Commands.Empresas;
using Projeto01.Application.Contracts;

namespace Projeto01.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasController : ControllerBase
    {
        private readonly IEmpresaApplicationService _empresaApplicationService;

        public EmpresasController(IEmpresaApplicationService empresaApplicationService)
        {
            _empresaApplicationService = empresaApplicationService;
        }

        [HttpPost]
        public IActionResult Post(EmpresaCreateCommand command)
        {
            try
            {
                _empresaApplicationService.Create(command);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
            
        }
    }
}
