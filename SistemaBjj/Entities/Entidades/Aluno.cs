using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Aluno")]
    public class Aluno : Base
    {
        public string CPF { get; set; }


        [ForeignKey("Faixa")]
        [Column(Order = 1)]
        public int FaixaID { get; set; }
        public Faixa Faixa { get; set; }

    }
}
