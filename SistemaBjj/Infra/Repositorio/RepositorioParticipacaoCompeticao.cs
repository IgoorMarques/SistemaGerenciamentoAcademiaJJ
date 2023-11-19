using Domain.Interfaces.ICompeticao;
using Domain.Interfaces.IParticipacaoCompeticao;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioParticipacaoCompeticao : RepositorioGenerics<ParticipacaoCompeticao>, InterfaceParticipacaoCompeticao
    {
        public async Task<IList<ParticipacaoCompeticao>> ListarInscricoesNaoPagas()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ParticipacaoCompeticao>> ListarInscricoesPaga()
        {
            throw new NotImplementedException();
        }

        public Task<IList<ParticipacaoCompeticao>> ListarTodosAlunosEmCompeticacaoEspecifica(int competicaoID)
        {
            throw new NotImplementedException();
        }

        public Task<int> TotalDeAlunosCompeticaoEspefica(int competicaoID)
        {
            throw new NotImplementedException();
        }
    }
}
