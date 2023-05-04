using CalculationCash.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            /*modelBuilder.Entity<ConvertedTransaction>()
                .Property(t => t.Guid).IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(t => t.Guid).IsRequired();

            modelBuilder.Entity<ReportAfterConversion>()
                .Property(t => t.Guid).IsRequired();

            modelBuilder.Entity<ReportBeforeConversion>()
                .Property(t => t.Guid).IsRequired();

            modelBuilder.Entity<User>()
                .Property(t => t.Guid).IsRequired();*/

            modelBuilder.Entity<ConvertedTransaction>()
            .HasOne(c => c.Transaction)
            .WithOne(t => t.ConvertedTransaction)
            .HasForeignKey<ConvertedTransaction>(c => c.GuidTransaction);

            modelBuilder.Entity<Transaction>()
                .HasOne(u => u.ConvertedTransaction)
                .WithOne(t => t.Transaction)
                .HasForeignKey<Transaction>(u => u.GuidConvertedTransaction);

        }

    }
}
