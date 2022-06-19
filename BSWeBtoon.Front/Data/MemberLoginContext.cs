using BSWeBtoon.Front.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BSWeBtoon.Front.Data
{
    public class MemberLoginContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BSWebtoon");
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ComicPic> ComicPics { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Member> Members = new List<Member>
            {
                new Member { MemberId="M001", MemberName="凍豆腐", CoinQuantity=200 , Login=1,setting="true"},
                new Member { MemberId="M002", MemberName="大阪燒", CoinQuantity=0 , Login=2,setting="true" },
                new Member { MemberId="M003", MemberName="鹽水雞", CoinQuantity=500 , Login=3,setting="true" },
                new Member { MemberId="M004", MemberName="我愛的cp都是真的!", CoinQuantity=1000 , Login=4,setting="true" },
                new Member { MemberId="M005", MemberName="一日顏狗，終生顏狗", CoinQuantity=300 , Login=1,setting="true" },
                new Member { MemberId="M006", MemberName="叫我大美女", CoinQuantity=400 , Login=2,setting="true" },
                new Member { MemberId="M007", MemberName="最帥就是我", CoinQuantity=100 , Login=3,setting="true" },
                new Member { MemberId="M008", MemberName="天下王者無雙", CoinQuantity=600 , Login=4,setting="true" },
                new Member { MemberId="M009", MemberName="迪特里是我ㄉ小可愛", CoinQuantity=700 , Login=1,setting="true" },
            };
            List<Keyword> Keywords = new List<Keyword>
            {
                new Keyword { KeywordDetailId="K001", ComicId="C001", },
                new Keyword { KeywordDetailId="K002", ComicId="C002",},
                new Keyword { KeywordDetailId="K003", ComicId="C003",},
                new Keyword { KeywordDetailId="K004", ComicId="C004",},
                new Keyword { KeywordDetailId="K005", ComicId="C005",},
                new Keyword { KeywordDetailId="K006", ComicId="C006",},
                new Keyword { KeywordDetailId="K007", ComicId="C007",},
                new Keyword { KeywordDetailId="K008", ComicId="C008",},
                new Keyword { KeywordDetailId="K009", ComicId="C009",},
            };
            List<Order> Orders = new List<Order>
            {
                new Order { OrderId="O001", MemberId="M001", GetId="G001",EpId="Ep01",StockId="S001",StartTime="",EndTime="",StockQuantity=12},
                new Order { OrderId="O002", MemberId="M002", GetId="G002",EpId="Ep02",StockId="S002",StartTime="",EndTime="",StockQuantity=10},
                new Order { OrderId="O003", MemberId="M003", GetId="G003",EpId="Ep03",StockId="S003",StartTime="",EndTime="",StockQuantity=0},
                new Order { OrderId="O004", MemberId="M004", GetId="G004",EpId="Ep04",StockId="S004",StartTime="",EndTime="",StockQuantity=5},
                new Order { OrderId="O005", MemberId="M005", GetId="G005",EpId="Ep05",StockId="S005",StartTime="",EndTime="",StockQuantity=7},
                new Order { OrderId="O006", MemberId="M006", GetId="G006",EpId="Ep06",StockId="S006",StartTime="",EndTime="",StockQuantity=1},
                new Order { OrderId="O007", MemberId="M007", GetId="G007",EpId="Ep07",StockId="S007",StartTime="",EndTime="",StockQuantity=2},
                new Order { OrderId="O008", MemberId="M008", GetId="G008",EpId="Ep08",StockId="S008",StartTime="",EndTime="",StockQuantity=3},
                new Order { OrderId="O009", MemberId="M009", GetId="G009",EpId="Ep09",StockId="S009",StartTime="",EndTime="",StockQuantity=4},
            };
            List<ComicPic> ComicPics = new List<ComicPic>
            {
                new ComicPic { ComicPicId="Cp01", EpId="Ep01",ComicId="C001",Jpg="https://tw-a.kakaopagecdn.com/P/C/12/c2/2x/e2b5ca4d-a05c-4ccd-91f5-5fbb1cd7ace0.webp",Sort=1},
                new ComicPic { ComicPicId="Cp02", EpId="Ep01",ComicId="C002",Jpg="https://tw-a.kakaopagecdn.com/P/C/108/c2/2x/dd7df4f7-372d-4c96-95c5-e5d16bb5ce78.webp",Sort=1},
                new ComicPic { ComicPicId="Cp03", EpId="Ep01",ComicId="C002",Jpg="https://tw-a.kakaopagecdn.com/P/C/108/c2/2x/dd7df4f7-372d-4c96-95c5-e5d16bb5ce78.webp",Sort=1},
                new ComicPic { ComicPicId="Cp04", EpId="Ep01",ComicId="C002",Jpg="https://tw-a.kakaopagecdn.com/P/C/123/c2/2x/bd6eea4a-54aa-4d23-a1d5-1d40c0709b4b.webp",Sort=1},
            };


            modelBuilder.Entity<Member>().HasData(Members);
            modelBuilder.Entity<Keyword>().HasData(Keywords);
            modelBuilder.Entity<Order>().HasData(Orders);
            modelBuilder.Entity<ComicPic>().HasData(ComicPics);
        }

    }

}
