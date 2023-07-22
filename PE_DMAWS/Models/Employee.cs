﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DMAWS_T2203E_NgThaiNguyen.Models
{
    [Table("Employees")]
    public class Employee
    {


        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is required.")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "Employee Name must be between 2 and 150 characters.")]
        public string EmployeeName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]

        public DateTime EmployeeDOB { get; set; }
        public virtual ICollection<ProjectEmployee> ProjectEmployees { get; set; }

        public bool IsOver16 => CalculateAge(EmployeeDOB) > 16;

        private int CalculateAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            // Kiểm tra nếu sinh nhật đã diễn ra trong năm nay
            if (dateOfBirth > today.AddYears(-age))
            {
                age--;
            }
            return age;
        }


    }
}
