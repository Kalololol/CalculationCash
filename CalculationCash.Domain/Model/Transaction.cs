using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class Transaction : Entity
    {
        public DateTime TimeTransaction { get; set; }
        public string Contract { get; set; }
        public string Instrument { get; set; }
        public string TypeTransakcion { get; set; }
        public string Direction { get; set; }
        public decimal Volume { get; set; }
        public decimal PurchasePrice { get; set; }
        public string OrderNumber { get; set; }
        public decimal Provision { get; set; }
        public decimal Commision { get; set; }
        public decimal Swap { get; set; }
        public decimal Profit { get; set; }
        public decimal ResultSum { get; set; }
        public string? GuidConvertedTransaction { get; set; }
        
        public virtual ConvertedTransaction? ConvertedTransaction { get; set; } 
        public string GuidReportBeforeConversion { get; set; }
        public virtual ReportBeforeConversion ReportBeforeConversion { get; set; }
        public string GuidUser { get; set; }
        public virtual User User { get; set; }
    }
}
