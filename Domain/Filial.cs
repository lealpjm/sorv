using System;
using System.Collections.Generic;

namespace Domain
{
    public class Filial
    {
        public Guid Id { get; set; }
        public string NomeFilial { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Saldos> Saldos { get; set; }
        public ICollection<Movimento> Movimentos { get; set; }

    }
}
