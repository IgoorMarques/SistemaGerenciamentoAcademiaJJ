using Domain.Interfaces.Generics;
using Domain.Interfaces.IAcademia;
using Domain.Interfaces.IAluno;
using Domain.Interfaces.IAlunoTurma;
using Domain.Interfaces.ICompeticao;
using Domain.Interfaces.IFaixa;
using Domain.Interfaces.IMensalidade;
using Domain.Interfaces.IParticipacaoCompeticao;
using Domain.Interfaces.IPodio;
using Domain.Interfaces.IProfessor;
using Domain.Interfaces.IResultado;
using Domain.Interfaces.ITurma;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ContextBase>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDefaultIdentity<AplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ContextBase>();


builder.Services.AddSingleton(typeof(InterfaceGeneric<>), typeof(RepositorioGenerics<>));
builder.Services.AddSingleton<InterfaceAcademia, RepositorioAcademia>();
builder.Services.AddSingleton<InterfaceAluno, RepositorioAluno>();
builder.Services.AddSingleton<InterfaceAlunoTurma, RepositorioAlunoTurma>();
builder.Services.AddSingleton<InterfaceCompeticao, RepositorioCompeticao>();
builder.Services.AddSingleton<InterfaceFaixa, RepositorioFaixa>();
builder.Services.AddSingleton<InterfaceMensalidade, RepositorioMensalidade>();
builder.Services.AddSingleton<InterfaceParticipacaoCompeticao, RepositorioParticipacaoCompeticao>();
builder.Services.AddSingleton<InterfacePodio, RepositorioPodio>();
builder.Services.AddSingleton<InterfaceProfessor, RepositorioProfessor>();
builder.Services.AddSingleton<InterfaceResultado, RepositorioResultado>();
builder.Services.AddSingleton<InterfaceTurma, RepositorioTurma>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
