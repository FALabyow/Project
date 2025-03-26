using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class SalesHistory
    {
        [Key]
        public Guid SalesHistoryId { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty; 
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; } 
        public ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
