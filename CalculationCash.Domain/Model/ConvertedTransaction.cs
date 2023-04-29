using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class ConvertedTransaction : Entity
    {
        public DateTime TimeTransaction { get; set; }
        public string OrderNumber { get; set; }
        public decimal Provision { get; set; }
        public decimal ProvisionByPLN { get; set; }
        public decimal Commision { get; set; }
        public decimal CommisionByPLN { get; set; }
        public decimal Swap { get; set; }
        public decimal SwapByPLN { get; set; }
        public decimal Profit { get; set; }
        public decimal ProfitByPLN { get; set; }
        public decimal ResultSum { get; set; }
        public decimal ResultSumByPLN { get; set; }
        public decimal ConverterByPLN { get; set; }
        public Guid GuidTransaction { get; set; }

    }
}
