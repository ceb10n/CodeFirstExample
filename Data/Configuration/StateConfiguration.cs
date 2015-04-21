using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class StateConfiguration : EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
            ToTable("States");

            HasKey(s => s.Id);

            Property(s => s.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(s => s.UF)
                .HasColumnType("char")
                .HasMaxLength(2)
                .IsRequired();

            Property(s => s.Name)
                .HasMaxLength(200)
                .IsRequired();

            Property(s => s.CountryIso)
                .HasColumnType("char")
                .HasMaxLength(2)
                .IsRequired();

            HasRequired(s => s.Country)
                .WithMany()
                .HasForeignKey(s => s.CountryIso)
                .WillCascadeOnDelete(false);
        }
    }
}
