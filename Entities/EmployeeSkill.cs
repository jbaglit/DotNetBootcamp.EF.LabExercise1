using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillId { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public int Level { get; set; }

        public int? YearsOfExperience { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal HourlyWage { get; set; }



    }
}
