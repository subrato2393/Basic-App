using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BasicApp.Application.DTOs.Product;
using BasicApp.Domain;
using BasicApp.Persistence.Repositories;
using MediatR;

namespace BasicApp.Application.Products.Handler.Query
{
    public class GetProductByIdRequestHandler : IRequestHandler<GetProductByIdRequest, ProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdRequestHandler(IProductRepository productRepository,
            IMapper mapper)
        { 
            _productRepository = productRepository;
            _mapper = mapper;
        }
          
        public async Task<ProductDto> Handle(GetProductByIdRequest request, CancellationToken cancellationToken)
        {
            var product=await _productRepository.GetProductByIdAsync(request.ProductId);
            var products = _mapper.Map<ProductDto>(product);

            return products;
        }
    } 
}
