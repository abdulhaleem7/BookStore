using BookStore.Domain.Enum;

namespace BookStore.Domain.Entities;

public class Book : AuditableEntity
{
    public string StoreId { get; set; } 
    public Store Store { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public BookStatus BookStatus { get; set; }
}