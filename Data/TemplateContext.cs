using EntityFrameworkExample.Maps;
using Microsoft.EntityFrameworkCore;
using template.Models;
using Template.Extensions;
using Template.Models;

namespace Template.Data
{
    public class TemplateContext : DbContext
    {
        public TemplateContext(DbContextOptions<TemplateContext> opt) : base(opt)
        {

        }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.ApplyConfiguration(new PersonneData()); 
        // }

        public DbSet<Personne> Personnes { get; set; }
        public DbSet<ExternalEntity> ExternalEntities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Notation> Notations { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ChangeTracker.SetAuditProperties();
            return await base.SaveChangesAsync(cancellationToken);
        }
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            ChangeTracker.SetAuditProperties();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
        public override int SaveChanges()
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonneMap());
            modelBuilder.ApplyConfiguration(new UserData());
        }


    }
}