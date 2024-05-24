using Microsoft.EntityFrameworkCore;

namespace server.Controllers
{
    public class ProductDetailContext : DbContext
    {
        public ProductDetailContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
