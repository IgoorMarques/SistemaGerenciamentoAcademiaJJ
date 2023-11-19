using Domain.Interfaces.ICompeticao;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioCompeticao : RepositorioGenerics<Competicao>, InterfaceCompeticao
    {
        public Task<Competicao> BuscarCompeticaoID(int competicaoID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Competicao>> ListarTodasCompeticoes()
        {
            throw new NotImplementedException();
        }
    }
}
