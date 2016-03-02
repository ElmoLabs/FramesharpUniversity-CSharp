using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Student : Framesharp.Domain.IDomainObject
    {
        public Student()
        { }
        
        public Student(Nullable<int> studentId)
        {
            this.StudentId = studentId;
        }
        
        public virtual Nullable<int> StudentId { get; set; }
        
        public virtual Person Person { get; set; }
        
        public virtual DateTime EnrollmentDate { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Student) != null  && this.StudentId == (obj as Student).StudentId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.StudentId).GetHashCode();
        }
    }
}
