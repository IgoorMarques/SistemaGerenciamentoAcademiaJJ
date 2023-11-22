using Domain.Interfaces.IAluno;
using Domain.Interfaces.InterfaceServicos;
using Entities.Entidades;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlunoController : ControllerBase
    {
        private readonly InterfaceAluno _interfaceAluno;
        private readonly IAlunoServico _interfaceAlunoServico;


        public AlunoController(InterfaceAluno interfaceAluno, IAlunoServico interfaceAlunoServico)
        {
            _interfaceAluno = interfaceAluno;
            _interfaceAlunoServico = interfaceAlunoServico;
        }


        [HttpGet("/api/ListaAlunosAcademia")]
        [Produces("application/json")]
        public async Task<Object> ListarAlunosAcademia()
        {
            return await _interfaceAluno.ListarTodosAlunos();  
        }


        [HttpPost("/api/AdicionarAluno")]
        [Produces("application/json")]
        public async Task<Object> AdicionarAluno(InputAlunoModel inputAlunoModel)
        {
            var novoAluno = new Aluno
            {
                Nome = inputAlunoModel.Nome,
                CPF = inputAlunoModel.CPF,
                FaixaID = inputAlunoModel.FaixaID,
            };
            await _interfaceAlunoServico.CadastrarAluno(novoAluno);
            return Task.FromResult(novoAluno);
        }




        private bool ValidaInputAnluno(InputAlunoModel inputAluno)
        {
            if(string.IsNullOrEmpty(inputAluno.Nome) || string.IsNullOrEmpty(inputAluno.CPF))
            {
                return false;
            }
            return true;
        }
        [HttpPut("/api/AtualizarAluno")]
        [Produces("application/json")]
        public async Task<Object> AtualizarAluno(InputAlunoModel inputAlunoModel, int alunoID)
        {
            var aluno = await _interfaceAluno.GetEntityByID(alunoID);
            var valid1 = ValidaInputAnluno(inputAlunoModel);
            if (aluno != null && valid1)
            {
                aluno.Nome = inputAlunoModel.Nome;
                aluno.CPF = inputAlunoModel.CPF;
                aluno.FaixaID = inputAlunoModel.FaixaID;
                await _interfaceAlunoServico.EditarAluno(aluno);
                return Task.FromResult(aluno);
            }
            return Task.FromResult("DADOS INCORRETOS");
            
        }


        [HttpGet("/api/ObterAluno")]
        [Produces("application/json")]
        public async Task<Object> ObterAluno(int alunoID)
        {
            var aluno = _interfaceAluno.GetEntityByID(alunoID);
            return await aluno;
        }

        [HttpDelete("/api/DeletarAluno")]
        [Produces("application/json")]
        public async Task<Object> DeletarAluno(int alunoID)
        {
            try
            {
                var alunoOb = await _interfaceAluno.GetEntityByID(alunoID);
                await _interfaceAluno.Delete(alunoOb);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
