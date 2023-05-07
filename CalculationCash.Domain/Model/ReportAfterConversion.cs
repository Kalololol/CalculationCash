using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportAfterConversion 
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public Guid ReportBeforeConversionId { get; set; }
        public ReportBeforeConversion ReportBeforeConversion { get; set; }
        public IList<ConvertedTransaction> ConvertedTransactions { get; set; } = new List<ConvertedTransaction>();
        public Guid UserId { get; set; }
        public User User { get; set; }

    }
}
