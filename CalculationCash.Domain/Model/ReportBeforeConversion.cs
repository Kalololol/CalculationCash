using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportBeforeConversion 
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public ReportAfterConversion ReportAfterConversion { get; set; }
        public Guid ReportAfterConversionId { get; set; }
        public IList<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
