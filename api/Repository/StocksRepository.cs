using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interface;
using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Dtos.Stock;

namespace api.Repository
{
    public class StocksRepository : IStocksRepository
    {
        private readonly ApplicationDBContext _context;
        public StocksRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Stock>> GetAllStocks()
        {
            return await _context.Stocks.Include(s => s.Comments).ToListAsync();
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