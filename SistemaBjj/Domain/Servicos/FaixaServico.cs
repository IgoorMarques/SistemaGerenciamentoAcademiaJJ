using Domain.Interfaces.IFaixa;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class FaixaServico : IFaixaServico
    {
        private readonly InterfaceFaixa _interfaceFaixa;
        public FaixaServico(InterfaceFaixa interfaceFaixa)
        {
            _interfaceFaixa = interfaceFaixa;
        }
        public async Task AdicionarNovaFaixa(Faixa faixa)
        {
            var faixaId = faixa.ValidaPropriedadeINT(faixa.Id, "FaixaID");
            var faixaD = faixa.ValidaPropriedadeString(faixa.Nome, "Descricao");
            if (faixaId && faixaD)
            {
                await _interfaceFaixa.Add(faixa);
            }
            
        }
    }
}
