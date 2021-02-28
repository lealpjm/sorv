using API_Sorv.Model;
using System;
using System.Collections.Generic;

namespace Core
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetAllProductByFilial(Guid filial);
    }
}
