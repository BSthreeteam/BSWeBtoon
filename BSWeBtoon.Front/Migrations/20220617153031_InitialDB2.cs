using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class InitialDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CommentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeReportedMemberId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportMemberId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportReasonId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportId);
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportId", "BeReportedMemberId", "CommentId", "ReportMemberId", "ReportReasonId" },
                values: new object[] { "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
