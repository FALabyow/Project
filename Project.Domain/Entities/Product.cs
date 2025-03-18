using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Product
    {
        public Guid ProductId { get; set; } = Guid.NewGuid();

        public string ProductCode { get; set; }
        public string BarcodeData {  get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity {  get; set; }
        public int ProductPreOrder {  get; set; }
        public DateTime ScannedAt { get; set; }  
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
