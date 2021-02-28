using System;

namespace Domain.VO
{
    public class ProdutoComSaldo
    {
        public string IdentificadorProduto { get; set; }
        public string NomeProduto { get; set; }
        public TimeSpan Validade { get; set; }
        public int Saldo { get; set; }
        public DateTime Data { get; set; }
        public Guid Filial { get; set; }
        public string NomeFilial { get; set; }
    }
}
