using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs
{
    public class DisplayAvailableProductsDto
    {
        public Guid StockId { get; set; }
        public string? BarcodeData { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int BuyersQuantity { get; set; }
        public decimal SubTotal { get; set; } = 0;
    }
}
