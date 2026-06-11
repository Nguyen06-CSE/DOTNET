using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Stock;
using api.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using api.Interface;
namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IStocksRepository _stocksRepository;
        public StockController(ApplicationDBContext context, IStocksRepository stocksRepository)
        {
            _context = context;
            _stocksRepository = stocksRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetALL()
        {
            var stocks = await _stocksRepository.GetAllStocks();
            var stockDTOs = stocks.Select(s => s.ToStockDTO());
            return Ok(stocks);
        } 
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var stock = await _stocksRepository.GetStockById(id);
            if (stock == null)
            {
                return NotFound();
            }
            return Ok(stock);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateStockRequestDTO createStockRequestDTO)
        {
            var stock = createStockRequestDTO.ToStockFromCreateDTO();
            var createdStock = await _stocksRepository.AddStock(stock);
            return CreatedAtAction(nameof(GetById), new { id = createdStock.Id }, createdStock);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var stock = await _stocksRepository.DeleteStock(id);
            if (stock == null)
            {
                return NotFound();
            }
            
            return NoContent();
        }
    }
}