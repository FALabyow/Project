using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs
{
    public class ProductDto
    {
        public string ProductCode { get; set; }
        public Guid ProductId { get; set; }
        public string BarcodeData { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductPreOrder { get; set; }
        public DateTime ScannedAt { get; set; }
        public Guid CategoryId { get; set; }
    }
}
