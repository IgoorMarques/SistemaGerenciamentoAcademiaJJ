using Domain.Interfaces.IAlunoTurma;
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
    public class RepositorioAlunoTurma : RepositorioGenerics<AlunoTurma>, InterfaceAlunoTurma
    {
        public Task<AlunoTurma> BuscarTumaPorID()
        {
            throw new NotImplementedException();
        }

        public Task<IList<AlunoTurma>> ListarTodasAsTurmas()
        {
            throw new NotImplementedException();
        }

        public Task<IList<AlunoTurma>> ListarTodosAlunosTurmaEspecifica(int turmaID)
        {
            throw new NotImplementedException();
        }
    }
}
