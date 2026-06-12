using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Interface
{
    public interface IStocksRepository
    {
        Task<List<Stock>> GetAllStocks();
        Task<Stock> GetStockById(int id);
        Task<Stock> AddStock(Stock stock);
        Task<Stock> DeleteStock(int id);
        Task<Stock?> UpdateStock(int id, UpdateStockRequestDTO stock);
    }
}