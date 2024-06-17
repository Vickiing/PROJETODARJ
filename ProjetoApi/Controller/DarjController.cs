using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProjetoApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DarjController : ControllerBase
    {
        private readonly ILogger<DarjController> _logger;

        public DarjController(ILogger<DarjController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public IActionResult  EmitirDarj([FromBody] int filial, string dataVencimento, decimal valor)
        {
            return Ok("Sucesso");
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return NotFound("Error!");
        }
    }
}