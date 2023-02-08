using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? ename { get; set; }
        public string? department { get; set; }
        public int? salary { get; set; }

    }
}
