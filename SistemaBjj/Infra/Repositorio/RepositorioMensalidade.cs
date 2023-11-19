using Domain.Interfaces.IMensalidade;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMensalidade : RepositorioGenerics<Mensalidade>, InterfaceMensalidade
    {
        public Task<Mensalidade> BuscarMensalidadeID(int mensalidadeID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Mensalidade>> ListarMensalidadesPagas()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Mensalidade>> ListarMensalidadesPendentes()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Mensalidade>> ListarMensalidadesVencidas()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Mensalidade>> ListarTodasMensalidades()
        {
            throw new NotImplementedException();
        }
    }
}
