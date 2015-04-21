using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class CountryConfiguration : EntityTypeConfiguration<Country>
    {
        public CountryConfiguration()
        {
            ToTable("Countries");

            HasKey(c => c.Iso);

            Property(c => c.Iso)
                .HasColumnType("char")
                .HasMaxLength(2);

            Property(c => c.Iso3)
                .HasColumnType("char")
                .HasMaxLength(3);

            Property(c => c.Name)
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
