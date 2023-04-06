﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CastTypes:AbstractSpr
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CastName { get; set; }
    }
}
