using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interface;
using Microsoft.EntityFrameworkCore;
using api.Models;

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
            return await _context.Stocks.ToListAsync();
        }
        public async Task<Stock> GetStockById(int id)
        {
            return await _context.Stocks.FirstOrDefaultAsync(s => s.Id == id);
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
    }
}