using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportBeforeConversion : Entity
    {
        public string ReportName { get; set; }
        //public string? GuidReportBeforeConversion { get; set; }
        public virtual ReportAfterConversion ReportAfterConversion { get; set; }
        public ICollection<Transaction> GuidTransaction { get; set; }
        //public string GuidUser { get; set; }
        public virtual User User { get; set; }
    }
}
