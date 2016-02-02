using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{

    public class Student : IdentityEntityBase
    {
        public Student()
        {
            this.Scores = new List<Score>();
        }

        [StringLength(255)]
        public string Name { get; set; }

        public Grade Grade { get; set; }
        
        public virtual IList<Score> Scores { get; set; }
        
        public virtual List<StudentSchool> StudentSchools { get; set; }
    }

    public enum Grade
    {
        PrimarySchool = 1,
        MiddleSchool = 2,
        HighSchool = 3,
        University = 4
    }
}