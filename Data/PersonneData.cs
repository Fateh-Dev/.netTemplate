using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Models;

namespace Template.Data;

public class PersonneData : IEntityTypeConfiguration<Personne>
{
    public void Configure(EntityTypeBuilder<Personne> builder)
    {
    }
}
