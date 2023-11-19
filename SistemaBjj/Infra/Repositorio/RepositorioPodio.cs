using Domain.Interfaces.IPodio;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioPodio : RepositorioGenerics<Podio>, InterfacePodio
    {
        public Task<IList<Podio>> ListarPodiosAlunosID(int alunoID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Podio>> ListarTodosPodiosCompeticaoEspecifica(int competicaoID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<int>> TotalMedalhas()
        {
            throw new NotImplementedException();
        }
    }
}
