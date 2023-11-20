using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IAlunoTurmaServico
    {
        Task AdicionarAlunoTurma(Aluno aluno, Turma turma);
        Task RemoverAlunoTurma(Aluno aluno, Turma turma);
    }
}
