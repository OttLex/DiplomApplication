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
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? ObjectId { get; set; }
        [Required]
        public int NumberOfZoom { get; set; }
        [Required]
        public int ActivityTypeId { get; set; }
        public string Description { get; set; } = "";
    }
}
