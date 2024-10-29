using CompaniaTest.Application.Contracts;
using CompaniaTest.Domain.Type;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompaniaTest.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniaController : ControllerBase
    {
        private readonly ILogger<CompaniaController> _logger;
        private readonly ICompaniaContract _contract;

        public CompaniaController(ILogger<CompaniaController> logger, ICompaniaContract contract)
        {
            _logger = logger;
            _contract = contract;
        }

        [HttpGet]
        public async Task<ActionResult<object>> GetCompanias()
        {
            try
            {
                List<CompaniaType> ListaCompanias = await _contract.GetCompanias()!;
                return StatusCode(StatusCodes.Status200OK, ListaCompanias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
