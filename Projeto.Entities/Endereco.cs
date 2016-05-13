using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class Endereco
    {
        public virtual int IdEndereco { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Estado { get; set; }
        public virtual string CEP { get; set; }

        #region Relacionamentos
        public virtual Funcionario Funcionario { get; set; }
        #endregion
    }
}
