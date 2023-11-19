using Domain.Interfaces.ICompeticao;
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
    public class RepositorioCompeticao : RepositorioGenerics<Competicao>, InterfaceCompeticao
    {

        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioCompeticao()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<Competicao> BuscarCompeticaoID(int competicaoID)
        {
            using( var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.competicaos
                    .Where(C => C.CompeticaoID.Equals(competicaoID))
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<IList<Competicao>> ListarTodasCompeticoes()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.competicaos.AsNoTracking().ToListAsync();
            }
        }
    }
}
