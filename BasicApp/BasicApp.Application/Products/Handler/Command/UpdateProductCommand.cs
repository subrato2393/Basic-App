using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicApp.Application.DTOs.Product;
using MediatR;

namespace BasicApp.Application.Products.Handler.Command
{ 
    public class UpdateProductCommand:IRequest
    {
        public ProductDto ProductDto { get; set; }
    }
}
 