using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs.SalesDetailDtos
{
    //DTOs for top selling and sold items
    public class GetSalesByQtyDto
    {
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public decimal TotalAmount { get; set; }

    }
}
