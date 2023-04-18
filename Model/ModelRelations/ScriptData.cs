
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Model.ModelRelations
{
    public class ScriptData: AbstractRel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdScript { get; set; }
        [Required]
        public int NumberOfStep { get; set; }
        [Required]
        public int IdBlocks { get; set; }
        [Required]
        public int IdBackground { get; set; }
        [Required]
        public int IdActivity { get; set; }
    }
}
