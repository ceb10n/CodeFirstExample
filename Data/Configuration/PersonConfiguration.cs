using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            ToTable("People");

            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                .IsRequired();

            Property(p => p.Email)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("UniqueEmail")
                        { IsUnique = true }));

            Property(p => p.NationalityId)
                .HasColumnType("char")
                .HasMaxLength(2);

            HasOptional(p => p.Nationality)
                .WithMany()
                .HasForeignKey(p => p.NationalityId)
                .WillCascadeOnDelete(false);

            HasOptional(p => p.Adress)
                .WithMany()
                .HasForeignKey(p => p.AdressId)
                .WillCascadeOnDelete(false);
        }
    }
}
