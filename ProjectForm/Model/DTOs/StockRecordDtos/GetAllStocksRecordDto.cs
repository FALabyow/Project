using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs.StockrRecordDtos
{
    public class GetAllStocksRecordDto
    {
        public Guid StockRecordId { get; set; }
        public string? ReferenceNum { get; set; }
        public int StockInQty { get; set; }
        public DateOnly StockInDate { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductCategory { get; set; }
        public Guid StockId { get; set; }
    }
}
