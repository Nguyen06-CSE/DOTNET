using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interface;
using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Dtos.Stock;
using api.Helps;

namespace api.Repository
{
    public class StocksRepository : IStocksRepository
    {
        private readonly ApplicationDBContext _context;
        public StocksRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Stock>> GetAllStocks(StocksQueryObject queryObject)
        {
            var stocks = _context.Stocks.AsQueryable();

            if (!string.IsNullOrEmpty(queryObject.Symbol))
            {
                stocks = stocks.Where(s => s.Symbol.Contains(queryObject.Symbol));
            }
            if (!string.IsNullOrEmpty(queryObject.CompanyName))
            {
                stocks = stocks.Where(s => s.CompanyName.Contains(queryObject.CompanyName));
            }

            if (queryObject.IsDescending)
            {
                stocks = stocks.OrderByDescending(s => s.Symbol);
            }

            return await stocks.ToListAsync();
        }
        public async Task<Stock> GetStockById(int id)
        {
            return await _context.Stocks.Include(s => s.Comments).FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<Stock> AddStock(Stock stock)
        {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();
            return stock;
        }
        public async Task<Stock> DeleteStock(int id)
        {
            var stock = await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);
            if (stock == null)
            {
                return null;
            }
            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();
            return stock;
        }

        public async Task<Stock?> UpdateStock(int id, UpdateStockRequestDTO stock)
        {
            var existingStock = await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);
            if (existingStock == null)
            {
                return null;
            }
            existingStock.Symbol = stock.Symbol;
            existingStock.CompanyName = stock.CompanyName;
            existingStock.Purchase = stock.Purchase;
            existingStock.LastDiv = stock.LastDiv;
            existingStock.Industry = stock.Industry;
            existingStock.MarketCap = stock.MarketCap;

            _context.Stocks.Update(existingStock);
            await _context.SaveChangesAsync();
            return existingStock;
        }

        
    }
}