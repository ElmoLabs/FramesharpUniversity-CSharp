using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Student : Framesharp.Domain.IDomainObject
    {
        public Student()
        { }
        
        public Student(System.Nullable<int> studentId)
        {
			StudentId = studentId;
        }
        
        public virtual System.Nullable<int> StudentId { get; set; }
        
        public virtual Person Person { get; set; }
        
        public virtual System.DateTime EnrollmentDate { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Student) != null  && this.StudentId == (obj as Student).StudentId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(StudentId).GetHashCode();
        }
    }
}
