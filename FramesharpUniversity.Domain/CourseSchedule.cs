using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class CourseSchedule : Framesharp.Domain.IDomainObject
    {
        public CourseSchedule()
        {
            this.CourseEnrollmentList = new List<CourseEnrollment>();
        }
        
        public CourseSchedule(Nullable<int> courseScheduleId)
        {
            this.CourseScheduleId = courseScheduleId;
        }
        
        public virtual Nullable<int> CourseScheduleId { get; set; }
        
        public virtual Course Course { get; set; }
        
        public virtual Instructor Instructor { get; set; }
        
        public virtual Classroom Classroom { get; set; }
        
        public virtual int CourseId { get; set; }
        
        public virtual int InstructorId { get; set; }
        
        public virtual int ClassroomId { get; set; }
        
        public virtual byte StartingHour { get; set; }
        
        public virtual byte StartingMinute { get; set; }
        
        public virtual byte FinshingHour { get; set; }
        
        public virtual byte FinshingMinute { get; set; }
        
        public virtual IList<CourseEnrollment> CourseEnrollmentList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as CourseSchedule) != null  && this.CourseScheduleId == (obj as CourseSchedule).CourseScheduleId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseScheduleId).GetHashCode();
        }
    }
}
