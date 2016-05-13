using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities;
using Projeto.Infra.Repositorio.Contracts;

namespace Projeto.Infra.Repositorio.Persistence
{
    public class RepositoryEndereco
        : RepositorioBase<Endereco, int>, IRepositoryEndereco
    {

    }
}
