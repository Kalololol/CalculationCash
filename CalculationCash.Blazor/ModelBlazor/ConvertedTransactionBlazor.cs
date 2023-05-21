namespace CalculationCash.Blazor
{
    public class ConvertedTransactionBlazor
    {
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
