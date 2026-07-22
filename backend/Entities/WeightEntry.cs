using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LiuwiTools.Api.Entities
{
	public class WeightEntry
	{
		public Guid Id { get; set; }
		public DateTime Timestamp { get; set; }
		public decimal Weight { get; set; }
		public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
	}

    public class WeightEntryConfiguration : IEntityTypeConfiguration<WeightEntry>
    {
        public void Configure(EntityTypeBuilder<WeightEntry> builder)
        {
            builder.HasKey(w => w.Id);
            builder.Property(w => w.Weight).HasPrecision(8, 1);
            builder.Property(w => w.Notes).HasMaxLength(500);
            builder.Property(w => w.Timestamp).HasColumnType("timestamp without time zone");
        }
    }
}
