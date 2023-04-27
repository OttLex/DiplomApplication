using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelSpr
{
    public class Activity:AbstractSpr
    {
        [Required]
        public int IdBackground { get; set; }
        public int? ObjectId { get; set; }
        [Required]
        public int ActivityTypeId { get; set; }
        public string Description { get; set; } = "";
    }
}
