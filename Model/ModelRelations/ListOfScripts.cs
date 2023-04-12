using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelRelations
{
    public class ListOfScripts
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdScript { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
