using API_Sorv.Model;
using Core;
using Core.Repositories;
using System;
using System.Collections.Generic;

namespace DomainServices
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetAllProductByFilial(Guid filial)
        {
            return _produtoRepository.Get(x => x.Filial == filial);
        }
    }
}
