using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.CrossCutting.Enums;

namespace Company.Storage.Entities
{
    [Table("JobPositions", Schema = "Company")]
    public class JobPosition
    {
        public Guid CompanyId { get; set; }

        public Company Company { get; set; }

        [MaxLength(256)]
        public string Name { get; set; } = null!;

        [MaxLength(1024)]
        [Required]
        public string Description { get; set; }

        [Required]
        public decimal GrossSalary { get; set; }

        public EmploymentType? EmploymentType { get; set; }

        [Required]
        public short WorkingWeekHours { get; set; }
    }
}
