using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ObjectCastDTO
    {
        public int Id { get; set; }
        public int IdBlock { get; set; }
        public string NameBlock { get; set; } = "";

        public int IdStep { get; set; }
        public int IdBackground { get; set; }
        public string NameBackground { get; set; } = "";

        public int IdActivity { get; set; }
        public string NameActivity { get; set; } = "";

        public int IdCastType { get; set; }
        public string NameCastType { get; set; } = "";

        public int IdObjectSpent { get; set; }
        public string NameObjectSpent { get; set; } = "";

        public int IdObjectRecive { get; set; }
        public string NameObjectRecive { get; set; } = "";

        public string Description { get; set; } = "";
    }
}
