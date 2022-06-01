using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Shift")]
        public string Shift { get; set; }
       


    }
}
