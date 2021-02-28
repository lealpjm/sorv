using API_Sorv.Model;
using Core.Repositories;
using Domain;
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
            var date = new DateTime(2021, 01, 01);

            var lst = new List<Saldos>() { 
                new Saldos() { Data = date, Produto = new Produto() { Id = "A001" }, Filial = new Filial() { Id = Guid.NewGuid() }, Id = 1, Saldo = 7 },
                new Saldos() { Data = date, Produto = new Produto() { Id = "A002" }, Filial = new Filial() { Id = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}") }, Id = 1, Saldo = 3 },
                new Saldos() { Data = date, Produto = new Produto() { Id = "A003" }, Filial = new Filial() { Id = new Guid("{9D84C578-8EE6-46CB-9C1D-6DE54B14EE27}") }, Id = 1, Saldo = 7 },
            };

            var repository = new Mock<ISaldosRepository>();
            repository.Setup(x => x.Get(It.IsAny<Expression<Func<Saldos, bool>>>(),
                                        It.IsAny<Func<IQueryable<Saldos>, IOrderedQueryable<Saldos>>>(),
                                        It.IsAny<string>()))
                .Returns((Expression<Func<Saldos, bool>> expr, Func<IQueryable<Saldos>, IOrderedQueryable<Saldos>> order, string include)
                => lst.AsQueryable()
                      .Where(expr));

            var service = new SaldosService(repository.Object);

            var rs = service.GetAllProductByFilial(guid, date);

            Assert.Equal(rs.Any(), retornoEsperado);

        }
    }
}
