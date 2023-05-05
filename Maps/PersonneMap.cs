

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Maps;
using Template.Models;

namespace EntityFrameworkExample.Maps;

public class PersonneMap : EntityMapBase<Personne>
{
    public override void Configure(EntityTypeBuilder<Personne> builder)
    {
        base.Configure(builder);
    }
}
