using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            ToTable("Cities");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Name)
                .HasMaxLength(200)
                .IsRequired();

            Property(c => c.County)
                .HasMaxLength(100);

            HasRequired(c => c.State)
                .WithMany()
                .HasForeignKey(c => c.StateId)
                .WillCascadeOnDelete(false);
        }
    }
}
