using ApiLocadoraVeiculo.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace ApiLocadoraVeiculo.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Veiculo> Carros { get; set; }

        public override int SaveChanges()
        {
            var entryListChange = ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null);

            foreach (var entry in entryListChange)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}