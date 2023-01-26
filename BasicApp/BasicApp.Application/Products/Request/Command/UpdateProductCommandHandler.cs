using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BasicApp.Application.DTOs.Product;
using BasicApp.Persistence.Repositories;
using MediatR;

namespace BasicApp.Application.Products.Handler.Command
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public UpdateProductCommandHandler(
                 IProductRepository productRepository,
                 IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product =await _productRepository.GetProductByIdAsync(request.ProductDto.ProductId);
            var updatedProduct = _mapper.Map(request.ProductDto, product);

            return await _productRepository.UpdateProductAsync(updatedProduct);
        }
    }
}
  