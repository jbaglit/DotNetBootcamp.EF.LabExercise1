using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        public int PlacementContractId { get; set; }
        public PlacementContract PlacementContract { get; set; }

        public int DayOfWeek { get; set; }

        public System.TimeSpan StartTime { get; set; }

        public System.TimeSpan EndTime { get; set; }

        public Byte NumberOfEmployees { get; set; }

        public Boolean Active { get; set; }

        [Column(TypeName = "NVARCHAR(100)")]
        public string? Notes { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
