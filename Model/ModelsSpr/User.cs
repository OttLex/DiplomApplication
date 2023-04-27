using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelsSpr
{
    public class User:AbstractSpr
    {
        [Required]
        public string Password { get; set; }

        [Required]
        public int AccessLevelId{ get; set; }
    }
}
