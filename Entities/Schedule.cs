using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        public DateTime Day { get; set; }

        public int ShiftId { get; set; }
        public Shift Shift { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        [Column(TypeName = "MONEY")]
        public decimal HourlyWage { get; set; }

        public Boolean OverTime { get; set; }

    }
}
