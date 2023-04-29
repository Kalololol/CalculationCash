using CalculationCash.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCash.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ConvertedTransaction> ConvertedTransactions {get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ReportAfterConversion> ReportAfterConversion { get; set; }
        public DbSet<ReportBeforeConversion> ReportBeforeConversion { get; set; }   
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
