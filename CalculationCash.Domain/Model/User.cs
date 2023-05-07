using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Domain.Model
{
    public class User 
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
        public IList<ReportBeforeConversion> ReportBeforeConversion { get; set; } = new List<ReportBeforeConversion>();
        public IList<ReportAfterConversion> ReportAfterConversion { get; set;} = new List<ReportAfterConversion>();
        


    }
}
