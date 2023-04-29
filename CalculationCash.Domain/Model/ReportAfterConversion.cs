using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportAfterConversion : Entity
    {
        public bool Deleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string ReportName { get; set; }
        public ReportBeforeConversion GuidReportBeforeConversion { get; set; }
        public IEnumerable<ConvertedTransaction> GuidConvertedTransactions { get; set; }
        
    }
}
