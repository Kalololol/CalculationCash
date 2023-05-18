namespace CalculationCash.Application
{
    public class CurrencyDto
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public Guid Id { get; set; }
        public string CurrencyName { get; set; }
        public string Code { get; set; }
        public decimal Mid { get; set; }
        public DateTime EffectiveDate { get; set; }

        public CurrencyDto()
        {
            
        }
    }
}
