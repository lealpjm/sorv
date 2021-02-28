using Core;
using Core.Repositories;
using Domain.VO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DomainServices
{
    public class SaldosService : ISaldosService
    {
        private readonly ISaldosRepository _produtoRepository;

        public SaldosService(ISaldosRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoComSaldo> GetAllProductByFilial(Guid filial, DateTime date)
        {
            return _produtoRepository.Get(x => x.Filial.Id == filial && x.Data == date, null, "Filial,Produto").Select(x => new ProdutoComSaldo()
            {
                IdentificadorProduto = x.Produto.Id,
                Filial = x.Filial.Id,
                Data = x.Data,
                Saldo = x.Saldo,
                NomeFilial = x.Filial.NomeFilial,
                NomeProduto = x.Produto.Descricao,
                Validade = x.Produto.TempoValidade.ToString("hh\\:mm\\:ss")
            });
        }
    }
}
