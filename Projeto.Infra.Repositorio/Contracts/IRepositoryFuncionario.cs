using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Common;

namespace Projeto.Infra.Repositorio.Contracts
{
    public interface IRepositoryFuncionario
        :IRepositoryBase<Funcionario, Int32>
    {
        List<DTOFuncionarioEndereco> FindAllFuncionarioEndereco();
        List<DTOQtdFuncionariosTipoContratacao> GroupByFuncionarioEndereco();
    }
}
