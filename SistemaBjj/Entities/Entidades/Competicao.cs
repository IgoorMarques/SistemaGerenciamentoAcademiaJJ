using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Competicao")]
    public class Competicao : Base
    {
        public int CompeticaoID { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
    }
}
