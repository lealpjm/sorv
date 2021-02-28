using API_Sorv.Model;
using Core.Repositories;
using DomainServices;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace Testes
{
    public class ProdutoTest
    {

        [Theory]
        [InlineData("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}", true)]
        [InlineData("{9D84C578-8EE6-46CB-9C1D-6DE54B14EE27}", true)]
        [InlineData("{9D94C546-8EE6-46CB-9C1D-6DE54B14EE27}", false)]
        [InlineData("{9D84C588-8EE6-46CB-9C1D-6DE54B14EE27}", false)]
        public void ListarProdutoPorFilial_RetornoEsperado_RetornaItensFilial(string guidStr, bool retornoEsperado)
        {
            Guid guid = new Guid(guidStr);

            var lst = new List<Produto>()
            {
                new Produto()
                {
                    Filial = Guid.NewGuid(),
                    Descricao = "A001-Desc",
                    Id = "A001",
                    Saldo = 7,
                    TempoValidade = TimeSpan.FromHours(6)
                },
                new Produto()
                {
                    Filial = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"),
                    Descricao = "A002-Desc",
                    Id = "A002",
                    Saldo = 7,
                    TempoValidade = TimeSpan.FromHours(6)
                },
                new Produto()
                {
                    Filial = new Guid("{9D84C578-8EE6-46CB-9C1D-6DE54B14EE27}"),
                    Descricao = "A003-Desc",
                    Id = "A003",
                    Saldo = 6,
                    TempoValidade = TimeSpan.FromHours(5)
                },

            };

            var repository = new Mock<IProdutoRepository>();
            repository.Setup(x => x.Get(It.IsAny<Expression<Func<Produto, bool>>>(),
                                        It.IsAny<Func<IQueryable<Produto>, IOrderedQueryable<Produto>>>(),
                                        It.IsAny<string>()))
                .Returns((Expression<Func<Produto, bool>> expr, Func<IQueryable<Produto>, IOrderedQueryable<Produto>> order, string include)
                => lst.AsQueryable()
                      .Where(expr));

            var service = new ProdutoService(repository.Object);

            var rs = service.GetAllProductByFilial(guid);

            Assert.Equal(rs.Any(), retornoEsperado);

        }
    }
}
