using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{

    public class Score : IdentityEntityBase
    {
        public Score()
        {
        }

        [Required]
        public int ScoreSum { get; set; }

        public int? ScoreEnglish { get; set; }

        public int? ScoreMath { get; set; }

        public Guid StudentId { get; set; }


        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }


    }
}