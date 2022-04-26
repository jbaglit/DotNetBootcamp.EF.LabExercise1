using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string Name { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string Street { get; set; }

        [Column(TypeName = "NVARCHAR(30)")]
        public string City { get; set; }

        [Column(TypeName = "NCHAR(2)")]
        public string Province { get; set; }

        [Column(TypeName = "NVARCHAR(50)")]
        public string? Contact { get; set; }

        [Column(TypeName = "CHAR(12)")]
        public char Phone { get; set; }

        public Boolean Active { get; set; }

        public ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}
