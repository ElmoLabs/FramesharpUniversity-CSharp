using System; 
using System.Collections.Generic; 
using System.Text; 
using FramesharpUniversity.Domain;
using FluentNHibernate.Mapping;

namespace FramesharpUniversity.Repository.Mappings
{
    public class ClassroomMap : ClassMap<Classroom>
    {
        public ClassroomMap()
        {
            this.Id(x => x.ClassroomId).GeneratedBy.Identity();

			Map(x => x.Name).Not.Nullable().Length(50);
        }
    }
}
