using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Common;
using Projeto.Service.Models;
using Projeto.Infra.Repositorio.Contracts;
using Projeto.Service.Models;
using Projeto.Entities.Types;
using Projeto.Entities;

namespace WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FuncionarioService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FuncionarioService.svc or FuncionarioService.svc.cs at the Solution Explorer and start debugging.
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IRepositoryFuncionario repository;

        public FuncionarioService(IRepositoryFuncionario repository)
        {
            this.repository = repository;
        }

        public string Cadastrar(FuncionarioModelCadastro model)
        {
            try
            {
                Funcionario f = new Funcionario();
                f.Endereco = new Endereco();
                f.Nome = model.Nome;
                f.DataAdmissao = model.DataAdmissao;
                f.TipoContratacao = (TipoContratacao)
                            Enum.Parse(typeof(TipoContratacao), model.TipoContratacao);
                f.Endereco.Logradouro = model.Logradouro;
                f.Endereco.Cidade = model.Cidade;
                f.Endereco.Estado = model.Estado;
                f.Endereco.CEP = model.Cep;
                return "Dados gravados.";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public List<DTOFuncionarioEndereco> Consultar()
        {
            return repository.FindAllFuncionarioEndereco();
        }

        public List<DTOQtdFuncionariosTipoContratacao> ConsultarPorTipo()
        {
            return repository.GroupByFuncionarioEndereco();
        }

    }
}
