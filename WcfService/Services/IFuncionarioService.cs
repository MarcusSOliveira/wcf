using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Projeto.Common;
using Projeto.Service.Models;

namespace WcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFuncionarioService" in both code and config file together.
    [ServiceContract]
    public interface IFuncionarioService
    {
        [OperationContract]
        string Cadastrar(FuncionarioModelCadastro model);

        [OperationContract]
        List<DTOFuncionarioEndereco> Consultar();

        [OperationContract]
        List<DTOQtdFuncionariosTipoContratacao> ConsultarPorTipo();        
    }
}
