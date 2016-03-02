using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Course : Framesharp.Domain.IDomainObject
    {
        public Course()
        {
            this.CourseEnrollmentList = new List<CourseEnrollment>();
            this.CourseInstructorList = new List<CourseInstructor>();
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Course(Nullable<int> courseId)
        {
            this.CourseId = courseId;
        }
        
        public virtual Nullable<int> CourseId { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual string Description { get; set; }
        
        public virtual IList<CourseEnrollment> CourseEnrollmentList { get; set; }
        
        public virtual IList<CourseInstructor> CourseInstructorList { get; set; }
        
        public virtual IList<CourseSchedule> CourseScheduleList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Course) != null  && this.CourseId == (obj as Course).CourseId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseId).GetHashCode();
        }
    }
}
