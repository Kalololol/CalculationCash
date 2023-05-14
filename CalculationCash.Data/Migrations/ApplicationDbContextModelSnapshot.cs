﻿// <auto-generated />
using System;
using CalculationCash.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculationCash.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalculationCash.Domain.Model.ConvertedTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Commision")
                        .HasColumnType("real");

                    b.Property<float>("CommisionByPLN")
                        .HasColumnType("real");

                    b.Property<float>("ConverterByPLN")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Profit")
                        .HasColumnType("real");

                    b.Property<float>("ProfitByPLN")
                        .HasColumnType("real");

                    b.Property<float>("Provision")
                        .HasColumnType("real");

                    b.Property<float>("ProvisionByPLN")
                        .HasColumnType("real");

                    b.Property<Guid>("ReportAfterConversionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ResultSum")
                        .HasColumnType("real");

                    b.Property<float>("ResultSumByPLN")
                        .HasColumnType("real");

                    b.Property<float>("Swap")
                        .HasColumnType("real");

                    b.Property<float>("SwapByPLN")
                        .HasColumnType("real");

                    b.Property<DateTime>("TimeTransaction")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReportAfterConversionId");

                    b.ToTable("ConvertedTransactions");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.Currency", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrencyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Mid")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportAfterConversion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid>("ReportBeforeConversionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ReportAfterConversion");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportBeforeConversion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<Guid>("ReportAfterConversionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReportName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ReportAfterConversionId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("ReportBeforeConversion");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Commision")
                        .HasColumnType("real");

                    b.Property<string>("Contract")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instrument")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Profit")
                        .HasColumnType("real");

                    b.Property<float>("Provision")
                        .HasColumnType("real");

                    b.Property<float>("PurchasePrice")
                        .HasColumnType("real");

                    b.Property<Guid>("ReportBeforeConversionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("ResultSum")
                        .HasColumnType("real");

                    b.Property<float>("Swap")
                        .HasColumnType("real");

                    b.Property<DateTime>("TimeTransaction")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeTransakcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<float>("Volume")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("ReportBeforeConversionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ConvertedTransaction", b =>
                {
                    b.HasOne("CalculationCash.Domain.Model.ReportAfterConversion", "ReportAfterConversion")
                        .WithMany("ConvertedTransactions")
                        .HasForeignKey("ReportAfterConversionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ReportAfterConversion");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportAfterConversion", b =>
                {
                    b.HasOne("CalculationCash.Domain.Model.User", "User")
                        .WithMany("ReportAfterConversion")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportBeforeConversion", b =>
                {
                    b.HasOne("CalculationCash.Domain.Model.ReportAfterConversion", "ReportAfterConversion")
                        .WithOne("ReportBeforeConversion")
                        .HasForeignKey("CalculationCash.Domain.Model.ReportBeforeConversion", "ReportAfterConversionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CalculationCash.Domain.Model.User", "User")
                        .WithMany("ReportBeforeConversion")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ReportAfterConversion");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.Transaction", b =>
                {
                    b.HasOne("CalculationCash.Domain.Model.ReportBeforeConversion", "ReportBeforeConversion")
                        .WithMany("Transactions")
                        .HasForeignKey("ReportBeforeConversionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ReportBeforeConversion");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportAfterConversion", b =>
                {
                    b.Navigation("ConvertedTransactions");

                    b.Navigation("ReportBeforeConversion");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.ReportBeforeConversion", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("CalculationCash.Domain.Model.User", b =>
                {
                    b.Navigation("ReportAfterConversion");

                    b.Navigation("ReportBeforeConversion");
                });
#pragma warning restore 612, 618
        }
    }
}