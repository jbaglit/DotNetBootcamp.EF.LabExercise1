using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        public string Description { get; set; }

        public Boolean RequiresTicket { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }

    }
}
