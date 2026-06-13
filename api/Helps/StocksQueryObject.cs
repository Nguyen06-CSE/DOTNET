using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helps
{
    public class StocksQueryObject
    {
        public string? Symbol { get; set; } = string.Empty;
        public string? CompanyName { get; set; } = string.Empty;
        public bool IsDescending { get; set; } = false;
    }
}