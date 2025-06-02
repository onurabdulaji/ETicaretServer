using ETicaretAPI.Domain.Entities.Commons;

namespace ETicaretAPI.Domain.Entities;
public class Order : BaseEntity
{
    public string Description { get; set; }
    public string Address { get; set; }

    // Iliski
    public ICollection<Product> Products { get; set; }
    public Guid CustomerId { get; set; }
    public Customer Customer { get; set; }
}
