using CalculationCash.Domain.Model;

namespace CalculationCash.Application
{
    public class ConvertedTransactionDto
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public DateTime TimeTransaction { get; set; }
        public string OrderNumber { get; set; }
        public float Provision { get; set; }
        public float ProvisionByPLN { get; set; }
        public float Commision { get; set; }
        public float CommisionByPLN { get; set; }
        public float Swap { get; set; }
        public float SwapByPLN { get; set; }
        public float Profit { get; set; }
        public float ProfitByPLN { get; set; }
        public float ResultSum { get; set; }
        public float ResultSumByPLN { get; set; }
        public float ConverterByPLN { get; set; }
        public Guid ReportAfterConversionDtoId { get; set; }
    }
}
