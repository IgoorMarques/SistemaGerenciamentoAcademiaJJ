using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Configuracao
{
    public class ContextBase : IdentityDbContext<AplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Academia> academias { set; get; }
        public DbSet<Aluno> alunos { set; get; }
        public DbSet<AlunoTurma> alunosTurmas { set; get; }
        
        public DbSet<Competicao> competicaos { set; get; }
        public DbSet<Faixa> faixas { set; get; }
        public DbSet<Mensalidade> mensalidades { set; get; }
        public DbSet<ParticipacaoCompeticao> participacaoCompeticaos { set; get; }
        public DbSet<Podio> podios { set; get; }
        public DbSet<Professor> professores { set; get; }
        public DbSet<Resultado> resultados { set; get; }
        public DbSet<Turma> turmas { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AplicationUser>().ToTable("Academia").HasKey(t => t.Id);
            builder.Entity<AlunoTurma>().ToTable("AlunoTurma").HasNoKey();
            builder.Entity<ParticipacaoCompeticao>().ToTable("ParticipacaoCompeticao").HasNoKey();
            base.OnModelCreating(builder);
        }

        public string ObterStringConexao()
        {
            return "Data Source=DESKTOP-2BDP1TA;Initial Catalog=SistemaAcademiaBJJ;Integrated Security=False;User ID=sa;Password=190477;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        }
    }
}
