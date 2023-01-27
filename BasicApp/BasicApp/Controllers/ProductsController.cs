using BasicApp.Application.DTOs.Product;
using BasicApp.Application.Products.Handler.Command;
using BasicApp.Application.Products.Handler.Query;
using BasicApp.Domain;
using BasicApp.Persistence;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BasicApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("getall-products")]
        public async Task<ActionResult> Get()
        {
            var query = new GetAllProductListRequest { };
            var productList = _mediator.Send(query);

            return Ok(productList.Result.ToList());
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<ActionResult<ProductDto>> GetById(int id)
        {
            var command = new GetProductByIdRequest { ProductId = id };
            var response = await _mediator.Send(command);
            return Ok(response); 
        }

        [HttpPost]
        [Route("save-product")]
        public async Task<ActionResult> Post(CreateProductDto createProductDto)
        {
            var command = new CreateProductCommand {CreateProductDto = createProductDto };
            var response =await _mediator.Send(command);
         
            return Ok(response);
        }                                                                                                        

        [HttpPut]
        [Route("update-product")]
        public async Task<ActionResult> Put(ProductDto product)
        {
            var command = new UpdateProductCommand { ProductDto = product };
            var response = _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete]
        [Route("delete-product")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteProductCommand { ProductId = id };
            var response = _mediator.Send(command);
            return Ok(response);
        }
    }
}
