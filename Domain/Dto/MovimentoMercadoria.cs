using System;

namespace Domain.Dto
{
    public class MovimentoMercadoria
    {
        public string IdProduto { get; set; }
        public int Saldo { get; set; }
        public int IdFuncionario { get; set; }
        public int IdFilial { get; set; }
        public TipoMovimento Movimento { get; set; }
        public DateTime DataMovimento { get; set; }
    }
}
