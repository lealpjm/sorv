using System;

namespace API_Sorv.Model
{
    public class Produto
    {
        public string Id { get; set; }
        public Guid Filial { get; set; }
        public string Descricao { get; set; }
        public int Saldo { get; set; }
        public TimeSpan TempoValidade { get; set; }
    }
}
