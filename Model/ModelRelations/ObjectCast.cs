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
        public int Id { get; set; }
        [Required]
        public int IdCastType { get; set; }
        [Required]
        public int IdObject { get; set; }
        [Required]
        public int IdStep { get; set; }
    }
}
