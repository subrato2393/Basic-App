using BasicApp.Application.DTOs.Product;
using BasicApp.Domain;
using MediatR;

namespace BasicApp.Application.Products.Handler.Query
{
    public class GetProductByIdRequest : IRequest<ProductDto>
    {
        public int ProductId { get; set; }
    }
}
  