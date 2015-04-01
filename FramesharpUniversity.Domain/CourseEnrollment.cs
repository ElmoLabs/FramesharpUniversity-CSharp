using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class CourseEnrollment : Framesharp.Domain.IDomainObject
    {
        public CourseEnrollment()
        { }
        
        public CourseEnrollment(System.Nullable<int> courseId, System.Nullable<int> courseScheduleId)
        {
			CourseId = courseId;
			CourseScheduleId = courseScheduleId;
        }
        
        public virtual System.Nullable<int> CourseId { get; set; }
        
        public virtual System.Nullable<int> CourseScheduleId { get; set; }
        
        public virtual Course Course { get; set; }
        
        public virtual CourseSchedule CourseSchedule { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as CourseEnrollment) != null  && this.CourseId == (obj as CourseEnrollment).CourseId && this.CourseScheduleId == (obj as CourseEnrollment).CourseScheduleId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(CourseId,CourseScheduleId).GetHashCode();
        }
    }
}
