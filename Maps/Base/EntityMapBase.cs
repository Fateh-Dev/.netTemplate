

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Models;

namespace Template.Maps;

public abstract class EntityMapBase<TEntity> : IEntityMap<TEntity> where TEntity : class, IEntityBase
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasQueryFilter(t => t.IsDeleted == false);
    }
}
