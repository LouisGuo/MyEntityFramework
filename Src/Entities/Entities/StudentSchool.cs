using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{
    public class StudentSchool : EntityCommon
    {
        [Key, Column(Order = 1)]
        public Guid StudentId { get; set; }

        [Key, Column(Order = 10)]
        public Guid SchoolId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }
    }
}