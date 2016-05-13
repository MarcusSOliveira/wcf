using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities.Types;

namespace Projeto.Entities
{
    public class Funcionario
    {
        public virtual int IdFuncionario { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Salario { get; set; }
        public virtual DateTime DataAdmissao { get; set; }
        public virtual TipoContratacao TipoContratacao { get; set; }

        #region Relacionamentos
        public virtual Endereco Endereco { get; set; }

        #endregion

    }
}
