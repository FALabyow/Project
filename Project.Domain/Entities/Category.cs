﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Product?> Products { get; set; }
    }
}
