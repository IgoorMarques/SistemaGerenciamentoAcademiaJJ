using Domain.Interfaces.IAluno;
using Domain.Interfaces.InterfaceServicos;
using Domain.Interfaces.ITurma;
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
    public class TurmaController : ControllerBase
    {
        private readonly InterfaceTurma _interfaceTurma;
        private readonly ITurmaServico _interfaceTurmaServico;


        public TurmaController(InterfaceTurma interfaceTurma, ITurmaServico interfaceTurmaServico)
        {
            _interfaceTurma = interfaceTurma;
            _interfaceTurmaServico = interfaceTurmaServico;
        }


        private bool ValidaTurmaModel(TurmaModel turma)
        {
            var valida = string.IsNullOrWhiteSpace(turma.Nome);
            var valida1 = turma.Hora > 0 && turma.Minutos > 0;
            if(!valida && valida1)
            {
                return true;
            }
            return false;
        } 

        [HttpPost("/api/CriarNovaTurma")]
        [Produces("application/json")]
        public async Task<Object> CriarTurma(TurmaModel turmaModel)
        {
            if (ValidaTurmaModel(turmaModel))
            {
                TimeSpan horario = new TimeSpan(turmaModel.Hora, turmaModel.Minutos, 0);
                var novaTurma = new Turma
                {
                    Nome = turmaModel.Nome,
                    Descricao = turmaModel.Descricao,
                    Horario = horario
                };
                await _interfaceTurmaServico.CriarTurma(novaTurma);
                return Task.FromResult($"Turma Criada: {novaTurma}");
            }
            return Task.FromResult("Dados incompletos");
        }

        [HttpPut("/api/AtualizarTurma")]
        [Produces("application/json")]
        public async Task<Object> AtualizarTurma(TurmaModel turmaModel, int turmaID) {
            var turma = _interfaceTurma.GetEntityByID(turmaID);
            var valida = ValidaTurmaModel(turmaModel);

            if (turma != null && valida)
            {
                var horario = new TimeSpan(turmaModel.Hora, turmaModel.Minutos, 0);
                Turma novaTurma = new Turma
                {
                    Nome = turmaModel.Nome,
                    Descricao = turmaModel.Descricao,
                    Horario = horario
                };
                await _interfaceTurma.Update(novaTurma);
            }

            return "Dados inválidos";

        
        }

        [HttpGet("/api/ListarTurmas")]
        [Produces("application/json")]
        public async Task<Object> ListarTurmas()
        {
            return await _interfaceTurma.ListarTodasAsTurmas();
        }

        [HttpDelete("/api/DeletarTurma")]
        [Produces("application/json")]
        public async Task<Object> ExcluirTurma(int turmaID)
        {
            return await _interfaceTurma.ExcluirTurma(turmaID);
        }
      
    }
}
