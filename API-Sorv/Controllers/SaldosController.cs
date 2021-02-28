using Core;
using Domain.VO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace API_Sorv.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaldosController : ControllerBase
    {

        private readonly ILogger<SaldosController> _logger;
        private readonly ISaldosService _produtoService;

        public SaldosController(ILogger<SaldosController> logger, ISaldosService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        [HttpGet]
        public IEnumerable<ProdutoComSaldo> Get(Guid filial, DateTime date)
        {
            return _produtoService.GetAllProductByFilial(filial, date);
        }
    }
}
