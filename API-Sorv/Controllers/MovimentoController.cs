using Core;
using Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace API_Sorv.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MovimentoController : ControllerBase
    {
        private readonly ILogger<MovimentoController> _logger;
        private readonly ISaldosService _saldosService;

        public MovimentoController(ILogger<MovimentoController> logger, ISaldosService saldosService)
        {
            _logger = logger;
            _saldosService = saldosService;
        }

        [HttpPost]
        public void RegistrarMovimento(List<MovimentoMercadoria> movimentos)
        {
            throw new NotImplementedException();
            //return _saldosService.RegistrarMovimentos(filial, date);
        }
    }
}
