using ETicaretAPI.Domain.Entities.Commons;

namespace ETicaretAPI.Domain.Entities;
public class Product : BaseEntity
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public float Price { get; set; }
    // Iliski
    public ICollection<Order> Orders { get; set; }
}
