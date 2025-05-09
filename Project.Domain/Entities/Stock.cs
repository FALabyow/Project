﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    //One-to-One Relationship with Product
    //This instance is created for each product instance
    public class Stock
    {
        public Guid StockId { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int ProductQuantity { get; set; } = 0;  
        public virtual Product? Product { get; set; }
    }
}
