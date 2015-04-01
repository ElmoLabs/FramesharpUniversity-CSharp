using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.Repository.Mappings
{
    public class CourseInstructorMap : ClassMap<CourseInstructor>
    {
        public CourseInstructorMap()
        {
			CompositeId().KeyProperty(x => x.CourseId).KeyProperty(x => x.InstructorId);

			References(x => x.Course);
			References(x => x.Instructor);
        }
    }
}
