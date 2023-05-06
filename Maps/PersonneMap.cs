

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Maps;
using Template.Models;

namespace EntityFrameworkExample.Maps;

public class PersonneMap : EntityMapBase<Personne>
{
    public override void Configure(EntityTypeBuilder<Personne> builder)
    {

        builder.HasData(
            new Personne() { Id = Guid.NewGuid(), IsDeleted = false, CreationTimeUtc = DateTime.UtcNow, Nom = "Djehinet", Prenom = "Djawed", Age = 1 },
            new Personne() { Id = Guid.NewGuid(), IsDeleted = false, CreationTimeUtc = DateTime.UtcNow, Nom = "Djehinet", Prenom = "Nadjib", Age = 32 },
            new Personne() { Id = Guid.NewGuid(), IsDeleted = false, CreationTimeUtc = DateTime.UtcNow, Nom = "Djehinet", Prenom = "Fateh", Age = 30 }
            );
        base.Configure(builder);
    }
}
