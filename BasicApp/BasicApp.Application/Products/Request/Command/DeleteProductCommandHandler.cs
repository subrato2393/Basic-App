using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BasicApp.Persistence.Repositories;
using MediatR;

namespace BasicApp.Application.Products.Handler.Command
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand,Unit>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public DeleteProductCommandHandler(
            IProductRepository productRepository,
            IMapper mapper
            )
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var command = _productRepository.DeleteProductAsync(request.ProductId);
            return Unit.Value;
        }
    }
}
  