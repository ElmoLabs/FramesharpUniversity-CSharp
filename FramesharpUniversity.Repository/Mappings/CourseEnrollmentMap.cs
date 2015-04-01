using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class CourseEnrollmentMap : ClassMap<CourseEnrollment>
    {
        public CourseEnrollmentMap()
        {
			CompositeId().KeyProperty(x => x.CourseId).KeyProperty(x => x.CourseScheduleId);

			References(x => x.Course);
			References(x => x.CourseSchedule);
        }
    }
}
