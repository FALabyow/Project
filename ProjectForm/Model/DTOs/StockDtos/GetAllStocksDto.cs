using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs.StockDtos
{
    public class GetAllStocksDto
    {
        public Guid StockId { get; set; }
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductCategory { get; set; }
        public int ProductQuantity { get; set; }
    }
}
