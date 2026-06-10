using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Models.Stock> Stocks { get; set; }
        public DbSet<Models.Comment> Comments { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data cho Stocks
            modelBuilder.Entity<Stock >().HasData(
                new Stock 
                { 
                    Id = 1,
                    Symbol = "AAPL",
                    CompanyName = "Apple Inc.",
                    Purchase = 150.50m,
                    LastDiv = 0.92m,
                    Industry = "Technology",
                    MarketCap = 2800000
                },
                new Stock 
                { 
                    Id = 2,
                    Symbol = "GOOGL",
                    CompanyName = "Alphabet Inc.",
                    Purchase = 2750.30m,
                    LastDiv = 0m,
                    Industry = "Technology",
                    MarketCap = 1800000
                }
            );

            // Seed data cho Comments
            modelBuilder.Entity<Comment>().HasData(
                new Comment 
                { 
                    Id = 1,
                    Title = "Great stock!",
                    Content = "This stock is performing very well.",
                    CreatedOn = new DateTime(2024, 1, 1, 10, 30, 0),
                    StockId = 1
                }
            );
        }
        
    }
}