using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities
{
    public class DepartmentRequestModel
    {
        public int DepartmentId { get; set; }
        public string Department_Name { get; set; }
    }
}
