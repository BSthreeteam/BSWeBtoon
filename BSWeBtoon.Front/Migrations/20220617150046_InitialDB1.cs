using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class InitialDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recharges",
                columns: table => new
                {
                    RechargeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoinId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RechargeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayMethod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recharges", x => x.RechargeId);
                });

            migrationBuilder.InsertData(
                table: "Recharges",
                columns: new[] { "RechargeId", "CoinId", "MemberId", "PayMethod", "RechargeDate" },
                values: new object[,]
                {
                    { "R0001", "1", "M0001", "1", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0002", "1", "M0001", "1", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0003", "3", "M0002", "1", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0004", "2", "M0003", "1", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0005", "1", "M0003", "1", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0006", "1", "M0003", "1", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "R0007", "2", "M0004", "1", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recharges");
        }
    }
}
