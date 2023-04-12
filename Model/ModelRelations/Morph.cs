using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class Morph:AbstractRel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdMorph { get; set; }
        [Required]
        public int IdObjectInTheComposition { get; set; }
    }
}
