using CalculationCash.Domain.Model;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Currency> Currency { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(eb =>
            {
                eb.Property(x => x.Deleted).HasDefaultValue(0);
                eb.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.UpdateDate).ValueGeneratedOnUpdate();
                eb.HasMany(x => x.ReportBeforeConversion).WithOne(b => b.User).HasForeignKey(b => b.UserId).OnDelete(DeleteBehavior.NoAction);
                eb.HasMany(x => x.ReportAfterConversion).WithOne(a => a.User).HasForeignKey(a => a.UserId).OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<Transaction>(eb =>
            {
                eb.Property(x => x.Deleted).HasDefaultValue(0);
                eb.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.UpdateDate).ValueGeneratedOnUpdate();
            });
            modelBuilder.Entity<ReportAfterConversion>(eb =>
            {
                eb.Property(x => x.Deleted).HasDefaultValue(0);
                eb.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.UpdateDate).ValueGeneratedOnUpdate();
                eb.HasMany(x => x.ConvertedTransactions).WithOne(t => t.ReportAfterConversion).HasForeignKey(t => t.ReportAfterConversionId).OnDelete(DeleteBehavior.NoAction);
                eb.HasOne(x => x.ReportBeforeConversion).WithOne(a => a.ReportAfterConversion).HasForeignKey<ReportAfterConversion>(a => a.ReportBeforeConversionId).OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<ReportBeforeConversion>(eb =>
            {
                eb.Property(x => x.Deleted).HasDefaultValue(0);
                eb.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.UpdateDate).ValueGeneratedOnUpdate();
                eb.HasMany(x => x.Transactions).WithOne(t => t.ReportBeforeConversion).HasForeignKey(t => t.ReportBeforeConversionId).OnDelete(DeleteBehavior.NoAction);
                eb.HasOne(x => x.ReportAfterConversion).WithOne(b => b.ReportBeforeConversion).HasForeignKey<ReportBeforeConversion>(b => b.ReportAfterConversionId).OnDelete(DeleteBehavior.NoAction);
             //   eb.HasOne(x => x.User).WithMany(u => u.ReportBeforeConversion).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
            });
            modelBuilder.Entity<ConvertedTransaction>(eb =>
            {
                eb.Property(x => x.Deleted).HasDefaultValue(0);
                eb.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                eb.Property(x => x.UpdateDate).ValueGeneratedOnUpdate();
            });

        }

    }
}
