using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Database.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string Department_Name { get; set; }
    }
}
