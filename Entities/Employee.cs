using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string FirstName { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string LastName { get; set; }

        [Column(TypeName = "CHAR(12)")]
        public char HomePhone { get; set; }

        public Boolean Active { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
