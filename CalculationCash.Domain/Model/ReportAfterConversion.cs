using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportAfterConversion : Entity
    {
        public string ReportName { get; set; }
       // public string GuidReportBeforeConversion { get; set; }
        public virtual ReportBeforeConversion ReportBeforeConversion { get; set; }
        public ICollection<ConvertedTransaction> GuidConvertedTransactions { get; set; }
        //public string GuidUser { get; set; }
        public virtual User User { get; set; }

    }
}
