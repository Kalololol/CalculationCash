using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ReportBeforeConversion : Entity
    {
        public bool Deleted { get; set; }
        public DateTime CreateDate { get; set; }
        public string ReportName { get; set; }
        public ReportAfterConversion? GuidReportBeforeConversion { get; set; }
        public ICollection<Transaction> GuidTransaction { get; set; }
        public User GuidUser { get; set; }
    }
}
