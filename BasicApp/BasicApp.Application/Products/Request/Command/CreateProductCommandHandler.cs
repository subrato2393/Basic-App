using AutoMapper;
using BasicApp.Application.DTOs.Product;
using BasicApp.Domain;
using BasicApp.Persistence.Repositories;
using MediatR;

namespace BasicApp.Application.Products.Handler.Command
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductDto>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<CreateProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(request.CreateProductDto);

            await _productRepository.AddProductAsync(product);

            return request.CreateProductDto;
        }
    }
}
