using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace BasicApp.Application.Products.Handler.Command
{
    public class DeleteProductCommand:IRequest
    { 
        public int ProductId { get; set; }
    }
}
 