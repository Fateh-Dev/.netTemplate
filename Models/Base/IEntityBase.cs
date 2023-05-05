namespace Template.Models
{
    public interface IEntityBase
    {
        Guid Id { get; set; }

        bool IsDeleted { get; set; }
    }
}
