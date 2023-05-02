using Model.ModelRelations;
using Model.ModelSpr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class MorphDTO
    {
        public int Id { get; set; }

        public int IdMorph { get; set; }
        public string NameMorph { get; set; }

        public int IdObjectInTheComposition { get; set; }
        public string NameObjectInTheComposition { get; set; }

    }
}
