using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs
{
    public class StockInDto
    {
        public Guid StockId { get; set; }
        public int ProductQuantity { get; set; }
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductStatus { get; set; }
        public DateOnly StockInDate { get; set; }
        public string? ReferenceNum { get; set; }
    }
}
