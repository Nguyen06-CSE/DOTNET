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
                },
                new Stock
        {
            Id = 3,
            Symbol = "MSFT",
            CompanyName = "Microsoft Corporation",
            Purchase = 420.75m,
            LastDiv = 3.00m,
            Industry = "Technology",
            MarketCap = 3100000
        },
        new Stock
        {
            Id = 4,
            Symbol = "AMZN",
            CompanyName = "Amazon.com Inc.",
            Purchase = 185.40m,
            LastDiv = 0m,
            Industry = "E-Commerce",
            MarketCap = 1900000
        },
        new Stock
        {
            Id = 5,
            Symbol = "TSLA",
            CompanyName = "Tesla Inc.",
            Purchase = 240.25m,
            LastDiv = 0m,
            Industry = "Automotive",
            MarketCap = 850000
        },
        new Stock
        {
            Id = 6,
            Symbol = "META",
            CompanyName = "Meta Platforms Inc.",
            Purchase = 510.60m,
            LastDiv = 2.00m,
            Industry = "Technology",
            MarketCap = 1300000
        },
        new Stock
        {
            Id = 7,
            Symbol = "NVDA",
            CompanyName = "NVIDIA Corporation",
            Purchase = 890.45m,
            LastDiv = 0.16m,
            Industry = "Semiconductors",
            MarketCap = 3200000
        },
        new Stock
        {
            Id = 8,
            Symbol = "JPM",
            CompanyName = "JPMorgan Chase & Co.",
            Purchase = 210.80m,
            LastDiv = 4.20m,
            Industry = "Banking",
            MarketCap = 600000
        },
        new Stock
        {
            Id = 9,
            Symbol = "V",
            CompanyName = "Visa Inc.",
            Purchase = 290.15m,
            LastDiv = 2.08m,
            Industry = "Financial Services",
            MarketCap = 550000
        },
        new Stock
        {
            Id = 10,
            Symbol = "KO",
            CompanyName = "The Coca-Cola Company",
            Purchase = 62.90m,
            LastDiv = 1.94m,
            Industry = "Beverages",
            MarketCap = 270000
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
                    Createby = new DateTime(2024, 1, 1, 10, 30, 0),
                    StockId = 1
                },
                new Comment
        {
            Id = 2,
            Title = "Strong AI Business",
            Content = "Google is investing heavily in artificial intelligence.",
            CreatedOn = new DateTime(2024, 1, 2),
            Createby = new DateTime(2024, 1, 1, 10, 30, 0),
            StockId = 2
        },
        new Comment
        {
            Id = 3,
            Title = "Cloud Leader",
            Content = "Azure remains a major growth driver for Microsoft.",
            CreatedOn = new DateTime(2024, 1, 3),
            Createby = new DateTime(2024, 1, 1, 10, 30, 0),
            StockId = 3
        },
        new Comment
        {
            Id = 4,
            Title = "E-commerce Giant",
            Content = "Amazon dominates online retail worldwide.",
            CreatedOn = new DateTime(2024, 1, 4),
            Createby = new DateTime(2024, 1, 1, 10, 30, 0),
            StockId = 4
        },
        new Comment
        {
            Id = 5,
            Title = "Volatile Stock",
            Content = "Tesla stock remains highly volatile but promising.",
            CreatedOn = new DateTime(2024, 1, 5),
            Createby = new DateTime(2024, 1, 1, 10, 30, 0),
            StockId = 5
        },
        new Comment
        {
            Id = 6,
            Title = "Social Media Powerhouse",
            Content = "Meta's advertising business is recovering strongly.",
            CreatedOn = new DateTime(2024, 1, 6),
            Createby = new DateTime(2024, 1, 1, 10, 30, 0),
            StockId = 6
        }
            );
        }
        
    }
}