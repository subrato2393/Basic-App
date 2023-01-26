using BasicApp.Domain;

namespace BasicApp.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly InterViewDbContext _context;
        public ProductRepository(InterViewDbContext context)
        {
            _context = context;
        }
        public async Task<Product> AddProductAsync(Product productDetails)
        {
           var result= _context.Product.Add(productDetails);
           _context.SaveChanges();
            return result.Entity;
        }

        public Task<int> DeleteProductAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            var product =_context.Product.ToList();
            return product;
        }

        public Task<int> UpdateProductAsync(Product productDetails)
        {
            throw new NotImplementedException();
        }
    }
}
