using Domain.Interfaces.ITurma;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioTurma : RepositorioGenerics<Turma>, InterfaceTurma
    {
        public Task<Turma> BuscarTurmaID(int turmaID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Turma>> ListarTodasAsTurmas()
        {
            throw new NotImplementedException();
        }
    }
}
