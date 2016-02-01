using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entities
{
    public abstract class EntityCommon
    {
        public EntityCommon()
        {
            this.CreateTime = DateTime.Now;
        }

        [Required]
        public DateTime CreateTime { get; set; }
    }
}