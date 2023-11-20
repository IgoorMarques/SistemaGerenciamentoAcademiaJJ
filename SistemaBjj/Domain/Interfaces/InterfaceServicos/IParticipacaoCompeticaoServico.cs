using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServicos
{
    public interface IParticipacaoCompeticaoServico
    {
        Task AdicionarAlunoCompeticao(int alunoID, int competicaoID);
        Task RemoverAlunoCompeticao(int alunoID);
        Task AlterarStatusInscricaoAluno(int alunoID);
    }
}
