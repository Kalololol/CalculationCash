using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class User : Entity
    {
        public DateTime LastModified { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string AddressEmail { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<ReportBeforeConversion>? ReportBeforeConversionGuid { get; set; }
        public ICollection<ReportAfterConversion>? ReportAfterConversionGuid { get; set;}


    }
}
