using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class AddDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keydetails",
                columns: table => new
                {
                    KeydetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keydetails", x => x.KeydetailId);
                });

            migrationBuilder.CreateTable(
                name: "WatchHistorys",
                columns: table => new
                {
                    WatchHistoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EpId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeoplePic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BgPic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicPicId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchHistorys", x => x.WatchHistoryId);
                });

            migrationBuilder.InsertData(
                table: "Keydetails",
                columns: new[] { "KeydetailId", "KeyName" },
                values: new object[,]
                {
                    { "K001", "恐怖" },
                    { "K002", "愛情" },
                    { "K003", "親情" },
                    { "K004", "BL" }
                });

            migrationBuilder.InsertData(
                table: "WatchHistorys",
                columns: new[] { "WatchHistoryId", "BgPic", "ComicId", "ComicPicId", "EpId", "MemberId", "PeoplePic" },
                values: new object[,]
                {
                    { "W001", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", "C001", "CP01", "Ep01", "M001", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg" },
                    { "W002", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", "C002", "CP02", "Ep02", "M002", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg" },
                    { "W003", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", "C003", "CP03", "Ep03", "M003", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg" },
                    { "W004", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", "C004", "CP04", "Ep04", "M004", "https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keydetails");

            migrationBuilder.DropTable(
                name: "WatchHistorys");
        }
    }
}
