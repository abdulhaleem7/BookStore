namespace BookStore.Domain.Entities;

public class Store : AuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
}