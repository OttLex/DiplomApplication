using System;
using System.ComponentModel.DataAnnotations;

namespace Model.ModelSpr
{
    public class Objects:AbstractSpr
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Morph { get; set; }
    }
}
