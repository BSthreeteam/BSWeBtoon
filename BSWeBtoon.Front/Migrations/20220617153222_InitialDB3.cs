using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class InitialDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0001");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0002");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0003");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0004");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0005");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0006");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "R0007");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "");

            migrationBuilder.InsertData(
                table: "Recharges",
                columns: new[] { "RechargeId", "CoinId", "MemberId", "PayMethod", "RechargeDate" },
                values: new object[,]
                {
                    { "RC0001", "1", "M0001", "1", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0002", "1", "M0001", "1", new DateTime(2022, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0003", "3", "M0002", "1", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0004", "2", "M0003", "1", new DateTime(2022, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0005", "1", "M0003", "1", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0006", "1", "M0003", "1", new DateTime(2022, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "RC0007", "2", "M0004", "1", new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "BeReportedMemberId", "CommentId", "ReportMemberId", "ReportReasonId" },
                values: new object[,]
                {
                    { "RP0001", "", "", "", "" },
                    { "RP0002", "", "", "", "" },
                    { "RP0003", "", "", "", "" },
                    { "RP0004", "", "", "", "" },
                    { "RP0005", "", "", "", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0001");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0002");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0003");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0004");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0005");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0006");

            migrationBuilder.DeleteData(
                table: "Recharges",
                keyColumn: "RechargeId",
                keyValue: "RC0007");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "RP0001");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "RP0002");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "RP0003");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "RP0004");

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportId",
                keyValue: "RP0005");

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

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "BeReportedMemberId", "CommentId", "ReportMemberId", "ReportReasonId" },
                values: new object[] { "", "", "", "", "" });
        }
    }
}
