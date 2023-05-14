using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class Currency
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public Guid Id { get; set; }
        public string CurrencyName { get; set; }
        public string Code { get; set; }
        public decimal Mid { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
