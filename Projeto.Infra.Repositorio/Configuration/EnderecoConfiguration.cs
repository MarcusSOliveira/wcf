using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entities;

namespace Projeto.Infra.Repositorio.Configuration
{
    public class EnderecoConfiguration
    : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.IdEndereco);

            Property(e => e.Logradouro)
                .HasMaxLength(250)
                .IsRequired();

            Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsRequired();

            Property(e => e.Estado)
                .HasMaxLength(25)
                .IsRequired();

            Property(e => e.CEP)
                .HasMaxLength(10)
                .IsRequired();

            #region Relacionamentos
            HasRequired(e => e.Funcionario)
                .WithOptional(f => f.Endereco);
            #endregion
        }


    }
}
