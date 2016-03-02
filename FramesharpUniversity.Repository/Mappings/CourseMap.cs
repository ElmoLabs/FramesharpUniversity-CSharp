using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class CourseMap : ClassMap<Course>
    {
        public CourseMap()
        {
            this.Id(x => x.CourseId).GeneratedBy.Identity();

			Map(x => x.Name).Not.Nullable().Length(50);
			Map(x => x.Description).Not.Nullable().Length(200);
        }
    }
}
