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
        public Guid SalesHistoryId { get; set; } //this is for Invoice number
        public DateOnly SaleDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public decimal TotalAmount { get; set; } // the total amount recorded for each transaction
        public ICollection<SalesDetail>? SalesDetails { get; set; }
    }
}
