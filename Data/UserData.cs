using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Models;

namespace Template.Data;

public class UserData : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {

        builder.HasData(
            new User() { Id = 1, FirstName = "djawed", Username = "djawed", LastName = "djehinet", PasswordHash = "$2a$11$EYjFiD/mUA9eCtNuS6O.du.ezBbIIaq1WQqUydaA8tmX/cC5bDVFK" }
            );

    }
}
