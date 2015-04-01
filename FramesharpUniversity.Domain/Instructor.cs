using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Instructor : Framesharp.Domain.IDomainObject
    {
        public Instructor()
        {
			CourseInstructorList = new List<CourseInstructor>();
			CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Instructor(System.Nullable<int> instructorId)
        {
			InstructorId = instructorId;
        }
        
        public virtual System.Nullable<int> InstructorId { get; set; }
        
        public virtual Person Person { get; set; }
        
        public virtual System.DateTime AdmissionDate { get; set; }
        
        public virtual IList<CourseInstructor> CourseInstructorList { get; set; }
        
        public virtual IList<CourseSchedule> CourseScheduleList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Instructor) != null  && this.InstructorId == (obj as Instructor).InstructorId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(InstructorId).GetHashCode();
        }
    }
}
