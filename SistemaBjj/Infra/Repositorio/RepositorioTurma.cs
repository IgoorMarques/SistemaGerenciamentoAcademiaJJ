using Domain.Interfaces.ITurma;
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
    public class RepositorioTurma : RepositorioGenerics<Turma>, InterfaceTurma
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public RepositorioTurma()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public async Task<Turma> BuscarTurmaID(int turmaID)
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.turmas.Where(T => T.TurmaID.Equals(turmaID))
                    .FirstOrDefaultAsync();
            }
        }

        public async Task<IList<Turma>> ListarTodasAsTurmas()
        {
            using (var banco = new ContextBase(_OptionsBuilder))
            {
                return await banco.turmas.AsNoTracking().ToListAsync();
            }
        }
    }
}
