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
    public class GetAllProductListRequestHandler : IRequestHandler<GetAllProductListRequest, List<ProductDto>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductListRequestHandler(IProductRepository productRepository,
            IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> Handle(GetAllProductListRequest request, CancellationToken cancellationToken)
        {
            var productList=await _productRepository.GetProductListAsync();
            var products = _mapper.Map<List<ProductDto>>(productList);

            return products;
        }
    } 
}
