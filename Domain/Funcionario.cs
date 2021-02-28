using System;
using System.Collections.Generic;

namespace Domain
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Filial Filial { get; set; }
        public DateTime DataInclusao { get; set; }
        public ICollection<Movimento> Movimentos { get; set; }
    }
}
