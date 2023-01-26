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

        public async Task<int> DeleteProductAsync(int id)
        {
           var product = _context.Product.Find(id);
           _context.Product.Remove(product);
           return  _context.SaveChanges();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = _context.Product.Where(x => x.ProductId == id).FirstOrDefault();
            return product;
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            var product =_context.Product.ToList();
            return product;
        }

        public async Task<int> UpdateProductAsync(Product productDetails)
        {
           _context.Product.Update(productDetails);
           return _context.SaveChanges();
        }
    }
}
