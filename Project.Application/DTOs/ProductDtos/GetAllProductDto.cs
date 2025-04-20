using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs.ProductDtos
{
    public class GetAllProductDto
    {
        public Guid ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? BarcodeData { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductReOrder { get; set; }
        public int ProductQuantity { get; set; }
        public DateTime ScannedAt { get; set; }
        public Guid CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
