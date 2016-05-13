using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entities;
using Projeto.Infra.Repositorio.Contracts;
using Projeto.Common;
using Projeto.Infra.Repositorio.DataSource;

namespace Projeto.Infra.Repositorio.Persistence
{
    public class RepositoryFuncionario
        : RepositorioBase<Funcionario, int>, IRepositoryFuncionario
    {
        public List<DTOFuncionarioEndereco> FindAllFuncionarioEndereco()
        {
            using (DataContext d = new DataContext())
            {
                return d.DbSetFuncionarios //Consulta em Funcionários
                        .Include(f => f.Endereco) //Join com endereco
                        .Select(
                            fe => new DTOFuncionarioEndereco()
                            {
                                IdFuncionario = fe.IdFuncionario,
                                Nome = fe.Nome,
                                Salario = fe.Salario,
                                DataAdmissao = fe.DataAdmissao,
                                TipoContratacao = fe.TipoContratacao.ToString(),
                                Logradouro = fe.Endereco.Logradouro,
                                Cidade = fe.Endereco.Cidade,
                                Estado = fe.Endereco.Estado,
                                CEP = fe.Endereco.CEP
                            }
                        ).ToList();

            }
            
        }

        public List<DTOQtdFuncionariosTipoContratacao> GroupByFuncionarioEndereco()
        {
            using (DataContext d = new DataContext())
            {
                return d.DbSetFuncionarios
                        .GroupBy(f => new { f.TipoContratacao })
                        .Select(
                            group => new DTOQtdFuncionariosTipoContratacao()
                            {
                                TipoContratacao = group.Key.TipoContratacao.ToString(),
                                QtdFuncionarios = group.Count()
                            }
                        ).OrderByDescending(dto => dto.QtdFuncionarios)
                        .ToList();
                    
            }
        }
    }
}
