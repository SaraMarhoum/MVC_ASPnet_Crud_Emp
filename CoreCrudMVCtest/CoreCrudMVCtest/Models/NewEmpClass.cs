using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreCrudMVCtest.Models
{
    public class NewEmpClass
    {
        [Key]

        public int Empid { get; set; }

        [Required(ErrorMessage = "Enter Employee Name !")]
        [Display(Name = "Employee Name")]
        public string Empname { get; set; }

        [Required(ErrorMessage = "Enter Email !")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Employee Age !")]
        [Display(Name = "Age")]
        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Employee Salary !")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

    }
}
