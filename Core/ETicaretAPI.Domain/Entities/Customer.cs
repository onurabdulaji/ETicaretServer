using ETicaretAPI.Domain.Entities.Commons;

namespace ETicaretAPI.Domain.Entities;
public class Customer : BaseEntity
{
    public string Name { get; set; }
    // Iliski
    public ICollection<Order> Orders { get; set; }
}
