﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApi.DTO
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}