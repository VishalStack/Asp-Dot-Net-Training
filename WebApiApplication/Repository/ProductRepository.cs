//namespace WebApiApplication.Repository
//{
//    public class ProductRepository : IProductRepository
//    {
//        private readonly DataContext _context;

//        public ProductRepository(DataContext context)
//        {
//            _context = context;
//        }

//        public async Task<IEnumerable<Product>> GetProducts()
//        {
//            return await _context.Products.ToListAsync();
//        }

//        public async Task<IEnumerable<Product>> Search(string name)
//        {
//            IQueryable<Product> query = _context.Products;
//            if (!string.IsNullOrEmpty(name))
//            {
//                query = query.Where(x => x.Name == name);
//            }
//            return await query.ToListAsync();
//        }
//    }
//}
