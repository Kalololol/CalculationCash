using CalculationCash.Domain.Model;

namespace CalculationCash.Application
{
    public class TransactionDto
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public DateTime TimeTransaction { get; set; }
        public string Contract { get; set; }
        public string Instrument { get; set; }
        public string TypeTransakcion { get; set; }
        public string Direction { get; set; }
        public float Volume { get; set; }
        public float PurchasePrice { get; set; }
        public string OrderNumber { get; set; }
        public float Provision { get; set; }
        public float Commision { get; set; }
        public float Swap { get; set; }
        public float Profit { get; set; }
        public float ResultSum { get; set; }
        public Guid ReportBeforeConversionDtoId { get; set; }
    }
}
