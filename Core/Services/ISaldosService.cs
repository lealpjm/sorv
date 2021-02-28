using Domain.VO;
using System;
using System.Collections.Generic;

namespace Core
{
    public interface ISaldosService
    {
        IEnumerable<ProdutoComSaldo> GetAllProductByFilial(Guid filial, DateTime date);

    }
}
