using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComicCheckTypes",
                columns: table => new
                {
                    ComicCheckTypeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ComicCheckTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicCheckTypes", x => x.ComicCheckTypeId);
                });

            migrationBuilder.InsertData(
                table: "ComicCheckTypes",
                columns: new[] { "ComicCheckTypeId", "ComicCheckTypeName" },
                values: new object[,]
                {
                    { "1", "審核過" },
                    { "2", "審核中" },
                    { "3", "未審核" },
                    { "4", "買版權" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComicCheckTypes");
        }
    }
}
