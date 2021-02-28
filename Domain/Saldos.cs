using API_Sorv.Model;
using System;

namespace Domain
{
    public class Saldos
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Produto Produto { get; set; }
        public Filial Filial { get; set; }
        public int Saldo { get; set; }

    }
}
