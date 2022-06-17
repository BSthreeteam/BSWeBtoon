using Microsoft.EntityFrameworkCore.Migrations;

namespace BSWeBtoon.Front.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoinQuantity = table.Column<int>(type: "int", nullable: false),
                    Login = table.Column<int>(type: "int", nullable: false),
                    setting = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberId);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "MemberId", "CoinQuantity", "Login", "MemberName", "setting" },
                values: new object[,]
                {
                    { "A001", 200, 1, "凍豆腐", true },
                    { "A002", 0, 2, "大阪燒", true },
                    { "A003", 500, 3, "鹽水雞", true },
                    { "A004", 1000, 4, "我愛的cp都是真的!", true },
                    { "A005", 300, 1, "一日顏狗，終生顏狗", true },
                    { "A006", 400, 2, "叫我大美女", true },
                    { "A007", 100, 3, "最帥就是我", true },
                    { "A008", 600, 4, "天下王者無雙", true },
                    { "A009", 700, 1, "迪特里是我ㄉ小可愛", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
