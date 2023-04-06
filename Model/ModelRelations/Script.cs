﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class Script: AbstractRel
    {
        [Key]
        public int Id;
        [Required]
        public int IdBlocks;
        [Required]
        public int IdBackground;
        [Required]
        public int IdActivity;
    }
}
