using Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Data.Configuration
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            ToTable("Teachers");

        }
    }
}
