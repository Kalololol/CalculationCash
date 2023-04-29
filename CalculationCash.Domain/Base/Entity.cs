using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain
{
    public class Entity
    {
        public Guid Guid { get; set; }
        public bool Deleted { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
