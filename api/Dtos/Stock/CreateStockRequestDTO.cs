using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using System.ComponentModel.DataAnnotations;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDTO
    {
        [Required]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Symbol must be between 1 and 10 characters.")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "CompanyName must be between 2 and 100 characters.")]
            public string CompanyName { get; set; } = string.Empty;
            [Required]
            [Range(1, 10000000, ErrorMessage = "Purchase price must be between 1 and 1,000,000.")]
            public decimal Purchase { get; set; }
            [Required]
            [Range(0.001,100, ErrorMessage = "LastDiv must be between 0.001 and 100.")]
            public decimal LastDiv { get; set; }
            [Required]
            [StringLength(100, MinimumLength = 2, ErrorMessage = "Industry must be between 2 and 100 characters.")]
            public string Industry { get; set; } = string.Empty;
                [Required]
                [Range(1, 1000000000000, ErrorMessage = "MarketCap must be between 1 and 1 trillion.")]
            public long MarketCap { get; set; }
    }
}