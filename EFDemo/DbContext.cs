using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    public class PagilaContext : DbContext
    {
        public DbSet<Actor> Actors => Set<Actor>();

        public PagilaContext(DbContextOptions<PagilaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("actor");

                entity.HasKey(e => e.ActorId);

                entity.Property(e => e.ActorId)
                      .HasColumnName("actor_id");

                entity.Property(e => e.FirstName)
                      .HasColumnName("first_name")
                      .HasMaxLength(45)
                      .IsRequired();

                entity.Property(e => e.LastName)
                      .HasColumnName("last_name")
                      .HasMaxLength(45)
                      .IsRequired();

                entity.Property(e => e.LastUpdate)
                      .HasColumnName("last_update");
            });
        }
    }
}
