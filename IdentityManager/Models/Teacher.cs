using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [DisplayName("TeacherName")]
        public string TeacherName { get; set; }
        [DisplayName("BirthDate")]
        public string BirthDate { get; set; }
        [DisplayName("Salary")]
        public double Salary { get; set; }
        [DisplayName("Qualification")]
        public string Qualification { get; set; }
        [DisplayName("Experience")]
        public string Experience { get; set; }

    }
}
