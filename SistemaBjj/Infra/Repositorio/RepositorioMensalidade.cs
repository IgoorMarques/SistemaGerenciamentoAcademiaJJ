using Domain.Interfaces.IMensalidade;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioMensalidade : RepositorioGenerics<Mensalidade>, InterfaceMensalidade
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositorioMensalidade()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }

        public async Task<Mensalidade> BuscarMensalidadeID(int mensalidadeID)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.mensalidades
                    .Where(M => M.Id.Equals(mensalidadeID))
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<IList<Mensalidade>> ListarMensalidadesPagas()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.mensalidades
                    .Where(MP => MP.Status.Equals("Paga"))
                    .AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Mensalidade>> ListarMensalidadesPendentes()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.mensalidades
                    .Where(MPT => MPT.Status.Equals("Pendente"))
                    .AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Mensalidade>> ListarMensalidadesVencidas()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.mensalidades
                    .Where(MM => MM.Status.Equals("Vencida"))
                    .AsNoTracking().ToListAsync();
            }
        }

        public async Task<IList<Mensalidade>> ListarTodasMensalidades()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.mensalidades.AsNoTracking().ToListAsync();
            }
        }
    }
}
