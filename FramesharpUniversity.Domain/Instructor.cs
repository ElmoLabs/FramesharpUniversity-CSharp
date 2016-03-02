using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Instructor : Framesharp.Domain.IDomainObject
    {
        public Instructor()
        {
            this.CourseInstructorList = new List<CourseInstructor>();
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Instructor(Nullable<int> instructorId)
        {
            this.InstructorId = instructorId;
        }
        
        public virtual Nullable<int> InstructorId { get; set; }
        
        public virtual Person Person { get; set; }
        
        public virtual DateTime AdmissionDate { get; set; }
        
        public virtual IList<CourseInstructor> CourseInstructorList { get; set; }
        
        public virtual IList<CourseSchedule> CourseScheduleList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Instructor) != null  && this.InstructorId == (obj as Instructor).InstructorId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.InstructorId).GetHashCode();
        }
    }
}
