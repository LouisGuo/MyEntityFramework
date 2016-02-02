using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{
    public class School : IdentityEntityBase
    {
        [StringLength(255), Required]
        public string Name { get; set; }

        [StringLength(1000), Required]
        public string Address { get; set; }

        public string Description { get; set; }

        //[NotMapped]
        public virtual List<StudentSchool> StudentSchools { get; set; }
    }
}