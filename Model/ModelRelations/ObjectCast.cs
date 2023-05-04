using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class ObjectCast : AbstractRel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdBlock { get; set; }
        [Required]
        public int IdStep { get; set; }
        [Required]
        public int IdBackground { get; set; }
        public int? IdActivity { get; set; }
        public int? IdCastType { get; set; }
        public int? IdObjectSpent { get; set; }
        public int? IdObjectRecive { get; set; }
        public string Description { get; set; } = "";
    }
}
