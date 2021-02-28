using API_Sorv.Model;
using System;

namespace Domain
{
    public class Movimento
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public Filial Filial { get; set; }
        public Funcionario Funcionario { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public DateTime DataMovimento { get; set; }
        public int ValorMovimento { get; set; }
    }
}
