using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Classroom : Framesharp.Domain.IDomainObject
    {
        public Classroom()
        {
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Classroom(Nullable<int> classroomId)
        {
            this.ClassroomId = classroomId;
        }
        
        public virtual Nullable<int> ClassroomId { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual IList<CourseSchedule> CourseScheduleList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Classroom) != null  && this.ClassroomId == (obj as Classroom).ClassroomId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.ClassroomId).GetHashCode();
        }
    }
}
