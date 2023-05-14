using CalculationCash.Domain.Model;

namespace CalculationCash.Application
{
    public class ReportAfterConversionDto
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public string ReportName { get; set; }
        public Guid ReportBeforeConversionDtoId { get; set; }
        public Guid UserDtoId { get; set; }
    }
}
