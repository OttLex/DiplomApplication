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
        [Required]
        public int IdScript { get; set; }
        public string Description { get; set; } = "";
    }
}
