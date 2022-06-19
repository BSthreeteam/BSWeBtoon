using BSWeBtoon.Front.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BSWeBtoon.Front.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //資料庫連線區
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BS");
        }


        //宣告關鍵字表
        public DbSet<Keydetail> Keydetails { get; set; }
        //宣告觀看紀錄表
        public DbSet<WatchHistory> WatchHistorys { get; set; }

        //種子資料區
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //關鍵字表
            List<Keydetail> Keydetails = new List<Keydetail>
            {
                new Keydetail { KeydetailId="K001", KeyName="恐怖" },
                new Keydetail { KeydetailId="K002", KeyName="愛情" },
                new Keydetail { KeydetailId="K003", KeyName="親情" },
                new Keydetail { KeydetailId="K004", KeyName="BL" },
            };

            modelBuilder.Entity<Keydetail>().HasData(Keydetails);


            //觀看紀錄表
            List<WatchHistory> WatchHistorys = new List<WatchHistory>
            {
                new WatchHistory { WatchHistoryId="W001",EpId="Ep01", MemberId="M001", ComicId="C001", PeoplePic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", BgPic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", ComicPicId="CP01"},
                new WatchHistory { WatchHistoryId="W002",EpId="Ep02", MemberId="M002", ComicId="C002", PeoplePic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", BgPic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", ComicPicId="CP02"},
                new WatchHistory { WatchHistoryId="W003",EpId="Ep03", MemberId="M003", ComicId="C003", PeoplePic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", BgPic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", ComicPicId="CP03"},
                new WatchHistory { WatchHistoryId="W004",EpId="Ep04", MemberId="M004", ComicId="C004", PeoplePic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", BgPic="https://www.niusnews.com/upload/imgs/default/2019MayJenny/24cute/1.jpg", ComicPicId="CP04"},
            };

            modelBuilder.Entity<WatchHistory>().HasData(WatchHistorys);

        }

    }

}
