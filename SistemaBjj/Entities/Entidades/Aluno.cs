using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Aluno")]
    public class Aluno
    {
        public int AlunoID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Faixa")]
        [Column(Order = 1)]
        public int FaixaID { get; set; }
        public Faixa Faixa { get; set; }

    }
}
