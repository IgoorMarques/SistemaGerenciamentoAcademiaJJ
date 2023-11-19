using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Faixa")]
    public class Faixa
    {
        public int FaixaID { get; set; }
        public EnumFaixa Descricao { get; set; }
    }
}
