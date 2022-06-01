using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }

         public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Batch { get; set; }
         public DateTime AddmissionDate { get; set; }
        public int RegistrationNo { get; set; }
        [NotMapped]
        public string Department { get; set; }

    }
}
