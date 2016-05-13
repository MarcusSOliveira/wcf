using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Projeto.Service.Models
{
    [DataContract]
    public class FuncionarioModelCadastro
    {
        [DataMember(IsRequired =true)]
        public string Nome { get; set; }

        [DataMember(IsRequired = true)]
        public decimal Salario { get; set; }

        [DataMember(IsRequired = true)]
        public DateTime DataAdmissao { get; set; }

        [DataMember(IsRequired = true)]
        public string TipoContratacao { get; set; }

        [DataMember(IsRequired = true)]
        public string Logradouro { get; set; }

        [DataMember(IsRequired = true)]
        public string Cidade { get; set; }

        [DataMember(IsRequired = true)]
        public string Estado { get; set; }

        [DataMember(IsRequired = true)]
        public string Cep { get; set; }
    }
}