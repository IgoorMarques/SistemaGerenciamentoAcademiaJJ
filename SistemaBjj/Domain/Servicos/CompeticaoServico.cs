using Domain.Interfaces.ICompeticao;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class CompeticaoServico : ICompeticaoServico
    {
        private readonly InterfaceCompeticao _interfaceCompeticao;
        public CompeticaoServico(InterfaceCompeticao interfaceCompeticao)
        {
            _interfaceCompeticao = interfaceCompeticao;
        }
        
        public async Task CriarCompeticao(Competicao competicao)
        {
            if (ValidaCompeticao(competicao)) await _interfaceCompeticao.Add(competicao); 
        }

        public async Task EditarCompeticao(Competicao competicao, string competicaoID)
        {
            if (ValidaCompeticao(competicao)) await _interfaceCompeticao.Update(competicao);
        }

        private bool ValidaCompeticao(Competicao competicao)
        {
            var compicaoNome = competicao.ValidaPropriedadeString(competicao.Nome, "Nome");
            return compicaoNome;
        }
    }
}
