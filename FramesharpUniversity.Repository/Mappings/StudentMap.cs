using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            this.Id(x => x.StudentId).GeneratedBy.Identity();

			References(x => x.Person);

			Map(x => x.EnrollmentDate).Not.Nullable();
        }
    }
}
