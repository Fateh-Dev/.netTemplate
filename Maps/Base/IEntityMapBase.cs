using Microsoft.EntityFrameworkCore;

namespace Template.Maps;

public interface IEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class
{

}
