using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(7)]
        [Index(IsUnique = true)]
        public string Code { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        [Index(IsUnique = true)]
        public string DepartmentName { get; set; }
        public List<Course> Courses { get; set; }

    }
}
