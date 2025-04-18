using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs.StockDtos
{
    public class UpdateStocksDto
    {
        public Guid StockId { get; set; }
        public int ProductQuantity { get; set; }
    }
}
