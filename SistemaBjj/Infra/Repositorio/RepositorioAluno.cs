using Domain.Interfaces.Generics;
using Domain.Interfaces.IAluno;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioAluno : RepositorioGenerics<Aluno>, InterfaceAluno
    {
        public Task<Aluno> BuscarAlunoID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Aluno>> ListarTodosAlunos()
        {
            throw new NotImplementedException();
        }
    }
}
