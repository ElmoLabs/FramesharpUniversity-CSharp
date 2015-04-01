using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class InstructorMap : ClassMap<Instructor>
    {
        public InstructorMap()
        {
            Id(x => x.InstructorId).GeneratedBy.Identity();

			References(x => x.Person);

			Map(x => x.AdmissionDate).Not.Nullable();
        }
    }
}
