using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelSpr
{
    public class Block:AbstractSpr
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdBackground { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; } = "";
    }
}
