using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Infra.Repositorio.Configuration
{
    class FuncionarioConfigurations
        :EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfigurations()
        {
            HasKey(f => f.IdFuncionario);
            Property(f => f.Nome)
                .HasMaxLength(50)
                .IsRequired();

            Property(f => f.Salario)
                .HasPrecision(18,2)
                .IsRequired();

            Property(f => f.DataAdmissao)
                .IsRequired();

            Property(f => f.TipoContratacao)           
                .IsRequired();

        }
    }
}
