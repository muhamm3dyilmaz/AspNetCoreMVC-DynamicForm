using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegisterApp.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "Email is required.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "FirstName is required.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required.")]
        public string? LastName { get; set; }
        public string? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public string? SelectedCourse { get; set; }
        public DateTime ApplyedAt { get; set; }

        public Candidate()
        {
            ApplyedAt = DateTime.Now;
        }
    }
}