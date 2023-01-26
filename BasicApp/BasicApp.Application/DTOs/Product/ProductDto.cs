using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApp.Application.DTOs.Product
{
    public class ProductDto
    { 
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public double? Qty { get; set; }
        public double? Price { get; set; }
    }
}
