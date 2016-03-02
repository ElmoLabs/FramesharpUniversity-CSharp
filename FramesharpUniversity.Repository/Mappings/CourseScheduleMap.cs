using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class CourseScheduleMap : ClassMap<CourseSchedule>
    {
        public CourseScheduleMap()
        {
            this.Id(x => x.CourseScheduleId).GeneratedBy.Identity();

			References(x => x.Course);
			References(x => x.Instructor);
			References(x => x.Classroom);

			Map(x => x.StartingHour).Not.Nullable();
            Map(x => x.StartingMinute).Not.Nullable();
            Map(x => x.FinshingHour).Not.Nullable();
            Map(x => x.FinshingMinute).Not.Nullable();
        }
    }
}
