using centrifuge.Domain.Entities;
using centrifuge.Repository.Configurations;
using Microsoft.EntityFrameworkCore;

namespace centrifuge.Repository
{
    public class CentrifugeContext : DbContext
    {
        public DbSet<DoorHistory> DoorHistories { get; set; }

        public CentrifugeContext(DbContextOptions<CentrifugeContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure
            modelBuilder.ApplyConfiguration(new DoorHistoryEntitySchemaDefinition());
        }
    }
}