using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForm.Model.DTOs
{
    public class SalesDetailInfoDto
    {
        public Guid ProductId { get; set; }
        public string ProductCode { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public Guid SalesHistoryId { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
