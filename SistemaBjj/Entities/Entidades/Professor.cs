using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Professor")]
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }
    }
}
