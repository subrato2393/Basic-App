using BasicApp.Application.DTOs.Product;
using BasicApp.Application.Products.Handler.Command;
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
            return Ok();
        }

        [HttpGet]
        [Route("getbyid")]
        public async Task<ActionResult> GetById(int id)
        {
            return Ok();
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
        public async Task<ActionResult> Put(Product product)
        {
            //var aProduct =_context.Product.Find(product.ProductId);
            //aProduct.Price = product.Price;
            //aProduct.Qty = product.Qty;
            //aProduct.Code = product.Code;

            //_context.Product.Update(aProduct);
            //_context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        [Route("delete-product")]
        public async Task<ActionResult> Delete(int id)
        {
            //var product = _context.Product.Find(id);

            //_context.Product.Remove(product);
            //_context.SaveChanges();

            return Ok();
        }
    }
}
