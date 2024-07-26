namespace BookStore.Domain.Contracts;
public abstract class BaseEntity : BaseEntity<string>
{

    protected BaseEntity() => Id = Guid.NewGuid().ToString();
}

public abstract class BaseEntity<TId>
{
    public TId Id { get; set; } = default!;
}