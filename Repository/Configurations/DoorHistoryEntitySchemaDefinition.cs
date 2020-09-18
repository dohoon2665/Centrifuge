using centrifuge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace centrifuge.Repository.Configurations
{
    public class DoorHistoryEntitySchemaDefinition : IEntityTypeConfiguration<DoorHistory>
    {
        public void Configure(EntityTypeBuilder<DoorHistory> builder)
        {
            builder.HasKey(itemHistory => itemHistory.DoorHistoryId);
        }
    }
}