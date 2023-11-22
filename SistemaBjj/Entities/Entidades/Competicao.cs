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
        public DateTime Data { get; set; }
    }
}
