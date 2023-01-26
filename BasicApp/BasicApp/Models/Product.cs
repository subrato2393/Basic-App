using System;
using System.Collections.Generic;

namespace BasicApp.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public double? Qty { get; set; }
        public double? Price { get; set; }
    }
}
