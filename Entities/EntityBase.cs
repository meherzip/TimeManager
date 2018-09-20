using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntityBase
    {
        public Employee UserInsert { get; set; }
        public DateTime DateInsert { get; set; }
        public Employee UserUpdate { get; set; }
        public DateTime DateUpdate { get; set; }
    }
}
