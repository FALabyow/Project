using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.DTOs
{
    public class GetAllSalesByDateDto
    {
        public Guid SalesDetailId { get; set; } //this if for Invoice#
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
