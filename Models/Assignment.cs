using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Assignment
    {
        [Key]

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Employeedesignation { get; set; }
        public DateTime EmpDoj { get; set; }



    }
}
