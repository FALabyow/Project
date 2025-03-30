
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    //One-to-One Relationship with SalesHistory
    //each sold product is stored in database using this class
    //the new instance of this class is created when the Checkout button is clicked in Cashier.cs
    public class SalesDetail
    {
        [Key]
        public Guid SalesDetailId { get; set; } = Guid.NewGuid(); 
        public Guid SalesHistoryId { get; set; } 
        public Guid ProductId { get; set; }
        public string? ProductCode { get; set; } 
        public string? ProductName { get; set; } 
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount => QuantitySold * UnitPrice;
        public SalesHistory? SalesHistory { get; set; }
    }
}
