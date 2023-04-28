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
        public int IdScript { get; set; }
        [Required]
        public int Step { get; set; }
        [Required]
        public int IdBlock { get; set; }
        [Required]
        public int IdBackgound { get; set; }
        [Required]
        public int IdActivity { get; set; }
        [Required]
        public bool IsResolve { get; set; }
        [Required]
        public int IdCastType { get; set; }
        [Required]
        public int IdObjectSpent { get; set; }
        [Required]
        public int IdObjectRecive { get; set; }
        public string Description { get; set; }
    }
}
