using BSWeBtoon.Front.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BSWeBtoon.Front.Data
{
    public class BSWebtoonDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BSWebtoonDB");
        }

        public DbSet<ComicCheckType> ComicCheckTypes { get; set; }
        public DbSet<Recharge> Recharges { get; set; }
        public DbSet<Report> Reports { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<ComicCheckType> ComicCheckTypes = new List<ComicCheckType>()
            {
                new ComicCheckType(){ ComicCheckTypeId = "1", ComicCheckTypeName = "審核過"},
                new ComicCheckType(){ ComicCheckTypeId = "2", ComicCheckTypeName = "審核中"},
                new ComicCheckType(){ ComicCheckTypeId = "3", ComicCheckTypeName = "未審核"},
                new ComicCheckType(){ ComicCheckTypeId = "4", ComicCheckTypeName = "買版權"},
            };
            modelBuilder.Entity<ComicCheckType>().HasData(ComicCheckTypes);

            List<Recharge> Recharges = new List<Recharge>()
            {
                new Recharge(){ RechargeId = "RC0001", MemberId = "M0001", CoinId = "1" , RechargeDate = new DateTime(2022,06,17) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0002", MemberId = "M0001", CoinId = "1" , RechargeDate = new DateTime(2022,06,17) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0003", MemberId = "M0002", CoinId = "3" , RechargeDate = new DateTime(2022,06,18) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0004", MemberId = "M0003", CoinId = "2" , RechargeDate = new DateTime(2022,06,18) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0005", MemberId = "M0003", CoinId = "1" , RechargeDate = new DateTime(2022,06,19) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0006", MemberId = "M0003", CoinId = "1" , RechargeDate = new DateTime(2022,06,19) ,PayMethod = "1"},
                new Recharge(){ RechargeId = "RC0007", MemberId = "M0004", CoinId = "2" , RechargeDate = new DateTime(2022,06,20) ,PayMethod = "1"},
            };
            modelBuilder.Entity<Recharge>().HasData(Recharges);

            List<Report> reports = new List<Report>()
            {
                new Report(){ ReportId = "RP0001" , CommentId = "" , BeReportedMemberId = "", ReportMemberId = "", ReportReasonId = ""},
                new Report(){ ReportId = "RP0002" , CommentId = "" , BeReportedMemberId = "", ReportMemberId = "", ReportReasonId = ""},
                new Report(){ ReportId = "RP0003" , CommentId = "" , BeReportedMemberId = "", ReportMemberId = "", ReportReasonId = ""},
                new Report(){ ReportId = "RP0004" , CommentId = "" , BeReportedMemberId = "", ReportMemberId = "", ReportReasonId = ""},
                new Report(){ ReportId = "RP0005" , CommentId = "" , BeReportedMemberId = "", ReportMemberId = "", ReportReasonId = ""},
            };
            modelBuilder.Entity<Report>().HasData(reports);
        }
    }
}
