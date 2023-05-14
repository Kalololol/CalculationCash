using CalculationCash.Domain.Model;

namespace CalculationCash.Application
{
    public class UserDto
    {
        public bool Deleted;
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid Id { get; set; }
        public DateTime LastModified { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
