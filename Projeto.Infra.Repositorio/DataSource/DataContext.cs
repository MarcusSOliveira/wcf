using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Infra.Repositorio.Configuration;

namespace Projeto.Infra.Repositorio.DataSource
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["wcf"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new FuncionarioConfigurations());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
        }

        public DbSet<Funcionario> DbSetFuncionarios { get; set; }
        public DbSet<Endereco> DbSetEnderecos { get; set; }

    }
}
