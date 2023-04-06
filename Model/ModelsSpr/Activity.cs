using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelsSpr
{
    public class Activity:AbstractSpr
    {
        [Key]
        public int Id;
        [Required]
        public string Name;
        public int? ObjectId;
        [Required]
        public int NumberOfZoom;
        [Required]
        public int ActivityTypeId;
        public string? Description;
    }
}
