using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ModelSpr
{
    public class Objects:AbstractSpr
    {
        [Required]
        public bool Morph { get; set; }
    }
}
