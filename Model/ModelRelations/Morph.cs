using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class Morph:AbstractRel
    {
        [Key]
        public int Id;
        [Required]
        public int IdMorph;
        [Required]
        public int IdObjectInTheComposition;
    }
}
