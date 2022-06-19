using BSWeBtoon.Front.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BSWeBtoon.Front.Data
{
    public class StockContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=kkwebtoonDB");
        }

        public DbSet<Stock> Stocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            List<Stock> stocks = new List<Stock>
            {
                new Stock{StockId="S0001",MemberId="M0001",ComicId="C0001",StockQuantity=5},
            };

            modelBuilder.Entity<Stock>().HasData(stocks);
        }
    }

}
