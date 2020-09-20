using System.Linq;

namespace SportsStore.Models
{
    public class EfStoreRepository : IStoreRepository
    {
        private StoreDbContext context;

        public EfStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
