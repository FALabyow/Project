using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    //One-to-Many Relationship with SalesDetail
    //Each checkout transaction is stored in database using this class
    //Similar to SalesDetail, the instance of this class is created every Checkout clicked.
    public class SalesHistory
    {
        [Key]
        public Guid SalesHistoryId { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; } 
        public ICollection<SalesDetail>? SalesDetails { get; set; }
    }
}
