using Microsoft.EntityFrameworkCore;
using Projeto01.Domain.Entities;
using Projeto01.Infra.Data.SqlServer.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Infra.Data.SqlServer.Contexts
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) 
            : base(options)
        {
         
        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent Mappings

            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FuncionarioMap());

            #endregion

            #region Indexes

            modelBuilder.Entity<Empresa>(entity =>
            {
                entity.HasIndex(e => e.Cnpj).IsUnique();
            });

            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasIndex(f => f.Cpf).IsUnique();
                entity.HasIndex(f => f.Matricula).IsUnique();
            });

            #endregion
        }
    }
}
