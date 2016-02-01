using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Entities
{

    public class Config
    {
        [Key, Column("Key"), StringLength(255)]
        public string Key { get; set; }

        [Column("Value")]
        public string Value { get; set; }
    }
}