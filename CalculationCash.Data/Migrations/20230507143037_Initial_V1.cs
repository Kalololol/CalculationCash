using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculationCash.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial_V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportAfterConversion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportBeforeConversionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportAfterConversion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportAfterConversion_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConvertedTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provision = table.Column<float>(type: "real", nullable: false),
                    ProvisionByPLN = table.Column<float>(type: "real", nullable: false),
                    Commision = table.Column<float>(type: "real", nullable: false),
                    CommisionByPLN = table.Column<float>(type: "real", nullable: false),
                    Swap = table.Column<float>(type: "real", nullable: false),
                    SwapByPLN = table.Column<float>(type: "real", nullable: false),
                    Profit = table.Column<float>(type: "real", nullable: false),
                    ProfitByPLN = table.Column<float>(type: "real", nullable: false),
                    ResultSum = table.Column<float>(type: "real", nullable: false),
                    ResultSumByPLN = table.Column<float>(type: "real", nullable: false),
                    ConverterByPLN = table.Column<float>(type: "real", nullable: false),
                    ReportAfterConversionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvertedTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConvertedTransactions_ReportAfterConversion_ReportAfterConversionId",
                        column: x => x.ReportAfterConversionId,
                        principalTable: "ReportAfterConversion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportBeforeConversion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportAfterConversionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportBeforeConversion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportBeforeConversion_ReportAfterConversion_ReportAfterConversionId",
                        column: x => x.ReportAfterConversionId,
                        principalTable: "ReportAfterConversion",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportBeforeConversion_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getutcdate()"),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeTransaction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Contract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instrument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeTransakcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<float>(type: "real", nullable: false),
                    PurchasePrice = table.Column<float>(type: "real", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provision = table.Column<float>(type: "real", nullable: false),
                    Commision = table.Column<float>(type: "real", nullable: false),
                    Swap = table.Column<float>(type: "real", nullable: false),
                    Profit = table.Column<float>(type: "real", nullable: false),
                    ResultSum = table.Column<float>(type: "real", nullable: false),
                    ReportBeforeConversionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transactions_ReportBeforeConversion_ReportBeforeConversionId",
                        column: x => x.ReportBeforeConversionId,
                        principalTable: "ReportBeforeConversion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConvertedTransactions_ReportAfterConversionId",
                table: "ConvertedTransactions",
                column: "ReportAfterConversionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportAfterConversion_UserId",
                table: "ReportAfterConversion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportBeforeConversion_ReportAfterConversionId",
                table: "ReportBeforeConversion",
                column: "ReportAfterConversionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReportBeforeConversion_UserId",
                table: "ReportBeforeConversion",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ReportBeforeConversionId",
                table: "Transactions",
                column: "ReportBeforeConversionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConvertedTransactions");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "ReportBeforeConversion");

            migrationBuilder.DropTable(
                name: "ReportAfterConversion");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
