using Domain.Interfaces.IAlunoTurma;
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
    public class AlunoTurmaServico : IAlunoTurmaServico
    {
        private readonly InterfaceAlunoTurma _interfaceTurma;
        public AlunoTurmaServico(InterfaceAlunoTurma interfaceTurma)
        {
            _interfaceTurma =  interfaceTurma;
        }
        public async Task AdicionarAlunoTurma(AlunoTurma alunoTurma)
        {
            if (ValidaAlunoTurma(alunoTurma)) await _interfaceTurma.Add(alunoTurma);
        }

        public async Task RemoverAlunoTurma(AlunoTurma alunoTurma)
        {
            if (ValidaAlunoTurma(alunoTurma))
            {
               await _interfaceTurma.Delete(alunoTurma);
            }
        }

        private bool ValidaAlunoTurma(AlunoTurma alunoTurma)
        {
            var alunoID = alunoTurma.ValidaPropriedadeINT(alunoTurma.AlunoID, "AlunoID");
            var turmaID = alunoTurma.ValidaPropriedadeINT(alunoTurma.TurmaID, "TurmaID");
            if (alunoID && turmaID)
            { return true; }
            else
            { return false; }
        }
    }
}
