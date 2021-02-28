using API_Sorv.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
            LoadTestData();
        }

        private void LoadTestData()
        {
            Produtos.Add(new Produto()
            {
                Id = "A0045",
                Filial = new Guid("{2331F54A-1DBF-4008-8C29-FFA8D2324600}"),
                Descricao = "Teste Prd 001",
                Saldo = 250,
                TempoValidade = TimeSpan.FromHours(4)
            });

            this.SaveChanges();
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
