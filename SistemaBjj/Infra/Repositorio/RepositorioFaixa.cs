using Domain.Interfaces.IFaixa;
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
    public class RepositorioFaixa : RepositorioGenerics<Faixa>, InterfaceFaixa
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioFaixa()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<IList<Faixa>> ListarFaixasDisponivels()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.faixas.AsNoTracking().ToListAsync();
            }
            
        }
    }
}
