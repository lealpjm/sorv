using API_Sorv.Model;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions opts) : base(opts)
        {
        }

        public DbSet<Saldos> Saldos { get; set; }
        public DbSet<Movimento> Movimento { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
               .SelectMany(t => t.GetForeignKeys())
               .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.NoAction;


            modelBuilder.Entity<Filial>().HasData(new { Id = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), NomeFilial = "Filial 001" });


            modelBuilder.Entity<Produto>().HasData(new { Id = "A0001", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 001", TempoValidade = TimeSpan.FromHours(4) });
            modelBuilder.Entity<Produto>().HasData(new { Id = "A0002", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 002", TempoValidade = TimeSpan.FromHours(3) });
            modelBuilder.Entity<Produto>().HasData(new { Id = "A0003", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 003", TempoValidade = TimeSpan.FromHours(6) });
            modelBuilder.Entity<Produto>().HasData(new { Id = "A0004", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 004", TempoValidade = TimeSpan.FromHours(5) });
            modelBuilder.Entity<Produto>().HasData(new { Id = "A0005", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 005", TempoValidade = TimeSpan.FromHours(4) });
            modelBuilder.Entity<Produto>().HasData(new { Id = "A0006", DataInclusao = new DateTime(2021, 01, 01), Descricao = "Produto 006", TempoValidade = TimeSpan.FromHours(3) });


            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 1, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0001", Saldo = 76 });
            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 2, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0002", Saldo = 8 });
            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 3, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0003", Saldo = 16 });
            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 4, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0004", Saldo = 31 });
            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 5, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0005", Saldo = 268 });
            modelBuilder.Entity<Saldos>().HasData(new { Data = new DateTime(2021, 01, 01), Id = 6, FilialId = new Guid("{9D94C576-8EE6-46CB-9C1D-6DE54B14EE27}"), ProdutoId = "A0006", Saldo = 302 });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
    }
}
