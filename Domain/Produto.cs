using Domain;
using System;
using System.Collections.Generic;

namespace API_Sorv.Model
{
    public class Produto
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public TimeSpan TempoValidade { get; set; }
        public ICollection<Movimento> Movimentos { get; set; }
        public ICollection<Saldos> Saldos { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}
