using System;
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
        public int Id { get; set; }
        public int IdScript { get; set; }
        public int IdStep { get; set; }
        [Required]
        public int IdBlocks { get; set; }
        [Required]
        public int IdBackground { get; set; }
        [Required]
        public int IdActivity { get; set; }
    }
}
