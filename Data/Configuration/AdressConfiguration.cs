using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class AdressConfiguration : EntityTypeConfiguration<Adress>
    {
        public AdressConfiguration()
        {
            ToTable("Adresses");

            HasKey(a => a.Id);

            Property(a => a.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Street)
                .IsRequired();
            
            Property(a => a.Number)
                .HasMaxLength(15);

            Property(a => a.ZipCode)
                .HasMaxLength(15);

            HasOptional(a => a.City)
                .WithMany()
                .HasForeignKey(a => a.CityId)
                .WillCascadeOnDelete(false);
        }
    }
}
