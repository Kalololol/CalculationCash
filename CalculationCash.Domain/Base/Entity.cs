using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain
{
    public class Entity
    {
        public bool Deleted;
        [Required]
        public DateTime CreateDate { get; set; }
        [Key]
        public Guid Guid { get; set; }


    }
}
