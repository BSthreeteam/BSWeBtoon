using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "StockId", "ComicId", "MemberId", "StockQuantity" },
                values: new object[] { "S0001", "C0001", "M0001", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "StockId",
                keyValue: "S0001");
        }
    }
}
