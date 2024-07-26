namespace BookStore.Domain.Contracts;

public abstract class AuditableEntity : AuditableEntity<Guid>
{
}

public abstract class AuditableEntity<T> : BaseEntity<T>, IAuditableEntity, ISoftDelete
{
    public Guid? CreatedBy { get; set; }
    public DateTime? CreatedOn { get; private set; } = DateTime.UtcNow;
    public Guid? LastModifiedBy { get; set; }
    public DateTime? LastModifiedOn { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedOn { get; set; }
    public Guid? DeletedBy { get; set; }
    public bool IsDeleted { get; set; }

    protected AuditableEntity() => CreatedOn = DateTime.UtcNow;
}