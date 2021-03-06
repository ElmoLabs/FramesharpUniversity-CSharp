using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class CourseInstructor : Framesharp.Domain.IDomainObject
    {
        public CourseInstructor()
        { }
        
        public CourseInstructor(Nullable<int> courseId, Nullable<int> instructorId)
        {
            this.CourseId = courseId;
            this.InstructorId = instructorId;
        }
        
        public virtual Nullable<int> CourseId { get; set; }
        
        public virtual Nullable<int> InstructorId { get; set; }
        
        public virtual Course Course { get; set; }
        
        public virtual Instructor Instructor { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as CourseInstructor) != null  && this.CourseId == (obj as CourseInstructor).CourseId && this.InstructorId == (obj as CourseInstructor).InstructorId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseId, this.InstructorId).GetHashCode();
        }
    }
}
