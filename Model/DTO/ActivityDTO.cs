using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ActivityDTO:AbstractSpr
    {
        public int ActivityTypeId { get; set; }
        public string ActivityName { get; set; }
        public string Description { get; set; }
    }
}
