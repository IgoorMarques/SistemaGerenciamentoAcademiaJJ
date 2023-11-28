using Domain.Interfaces.IAluno;
using Domain.Interfaces.ICompeticao;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompeticaoController : ControllerBase
    {
        private readonly InterfaceCompeticao _interfaceCompeticao;
        private readonly ICompeticaoServico _IcompeticaoServico;

        public CompeticaoController(InterfaceCompeticao interfaceCompeticao,
            ICompeticaoServico icompeticaoServico)
        {
            _interfaceCompeticao = interfaceCompeticao;
            _IcompeticaoServico = icompeticaoServico;
        }

        [HttpGet("/api/ListaCompeticoesAcademia")]
        [Produces("application/json")]
        public async Task<Object> ListarCompeticao()
        {
            return await _interfaceCompeticao.ListarTodasCompeticoes();
        }

        [HttpPut("/api/EditarCompeticaoAcademia")]
        [Produces("application/json")]
        public async Task<Object> EditarCompeticao(int turmaID, InputCompeticaoModel inputCompeticao)
        {
            var competicao = await _interfaceCompeticao.GetEntityByID(turmaID);
            if(competicao == null)
            {
                return NotFound("Não contido");
            }
            competicao.Nome = inputCompeticao.Nome;
            competicao.Data = inputCompeticao.Data;
            await _interfaceCompeticao.Update(competicao);
            return Ok("Competição editada com sucesso!");
        }

        [HttpPost("/api/CriarCompeticao")]
        [Produces("application/json")]
        public async Task<Object> CriarCompeticao(InputCompeticaoModel competicaoModel)
        {
            if (competicaoModel.Equals(null))
            {
                return BadRequest("Campo nome é obrigatorio");
            }
            if (competicaoModel.Equals(null))
            {
                return BadRequest("A data é obrigatória");
            }
            var competicao = new Competicao
            {
                Nome = competicaoModel.Nome,
                Data = competicaoModel.Data
            };

            await _interfaceCompeticao.Add(competicao);
            return Ok("Competição criada com sucesso");
        }

        [HttpDelete("/api/DeletarCompeticao")]
        [Produces("application/json")]
        public async Task<Object> DeletarCompeticao(int competicaoID)
        {
            var competicao = await _interfaceCompeticao.GetEntityByID(competicaoID);
            if (competicao.Equals(null))
            {
                return NotFound("Competição não encontrada");
            }
            await _interfaceCompeticao.Delete(competicao);
            return Ok("Competição excluida com sucesso!");
        }



    }
}
