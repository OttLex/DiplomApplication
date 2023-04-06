using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class ObjectCast:AbstractRel
    {
        [Key]
        public int Id;
        [Required]
        public int IdCastType;
        [Required]
        public int IdObject;
        [Required]
        public int IdStep;
    }
}
