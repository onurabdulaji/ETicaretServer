
namespace ETicaretAPI.Persistence.Repositories;
public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}
