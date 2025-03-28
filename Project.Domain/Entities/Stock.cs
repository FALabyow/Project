using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    //One-to-One Relationship with Product
    public class Stock
    {
        public Guid StockId { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int ProductQuantity { get; set; } = 0;
        public string ProductStatus
        {
            get
            {
                if (ProductQuantity <= 0)
                    return "Out of Stock";
                else if (ProductQuantity <= Product?.ProductReOrder)
                    return "Critical";
                else
                    return "Available";
            }
        }
        public virtual Product? Product { get; set; }
    }
}
