using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ITurma;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class TurmaServico : ITurmaServico
    {
        private readonly InterfaceTurma _interfaceTurma;

        public TurmaServico(InterfaceTurma interfaceTurma)
        {
            _interfaceTurma = interfaceTurma;
        }
        public async Task CriarTurma(Turma turma)
        {
            await _interfaceTurma.Add(turma);
        }

        public async Task EditarTurma(Turma turma, int turmaID)
        {
            await _interfaceTurma.Update(turma);
        }

        public async Task ExcluirTurma(int turmaID)
        {
            await _interfaceTurma.ExcluirTurma(turmaID);
        }
    }
}
