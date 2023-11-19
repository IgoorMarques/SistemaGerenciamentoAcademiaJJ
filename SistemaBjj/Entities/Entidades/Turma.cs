using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entidades
{
    [Table("Turma")]
    public class Turma
    {
        public int TurmaID { get; set; }
        public string Descricao { get; set; }
        public TimeSpan Horario { get; set; }

        [ForeignKey("Professor")]
        public int? ProfessorID { get; set; }
        public Professor Professor { get; set; }
    }
}
