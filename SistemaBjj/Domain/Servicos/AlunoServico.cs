using Domain.Interfaces.IAluno;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class AlunoServico : IAlunoServico
    {
        private readonly InterfaceAluno _interfaceAluno;
        public AlunoServico(InterfaceAluno interfaceAluno)
        {
            _interfaceAluno = interfaceAluno;
        }
        public async Task CadastrarAluno(Aluno aluno)
        {
            if(ValidaAluno(aluno))
            {
                await _interfaceAluno.Add(aluno);
            }
            
        }

        private bool ValidaAluno(Aluno aluno)
        {
            var validNome = aluno.ValidaPropriedadeString(aluno.Nome, "Nome");
            var validCPF = aluno.ValidaPropriedadeString(aluno.CPF, "CPF");
            var validFaixaID = aluno.ValidaPropriedadeINT(aluno.FaixaID, "FaixaID");

            if (validNome && validCPF && validFaixaID)
            {
                return true;
            }
            return false;
        }

        public async Task EditarAluno(Aluno aluno)
        {
            if (ValidaAluno(aluno))
            {
                await _interfaceAluno.Update(aluno);
            }

        }

        public async Task ExcluirAluno(Aluno aluno)
        {
            if (aluno.ValidaPropriedadeINT(aluno.AlunoID, "AlunoID"))
            {
                await _interfaceAluno.Delete(aluno);
            }
            
        }
    }
}
