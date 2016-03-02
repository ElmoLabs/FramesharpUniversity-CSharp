using System;
using System.Text;
using System.Collections.Generic;

namespace FramesharpUniversity.Domain
{
    public class Person : Framesharp.Domain.IDomainObject
    {
        public Person()
        {
            this.InstructorList = new List<Instructor>();
            this.StudentList = new List<Student>();
        }
        
        public Person(Nullable<long> documentNumber)
        {
            this.DocumentNumber = documentNumber;
        }
        
        public virtual Nullable<long> DocumentNumber { get; set; }
        
        public virtual string Name { get; set; }
        
        public virtual string Gender { get; set; }
        
        public virtual IList<Instructor> InstructorList { get; set; }
        
        public virtual IList<Student> StudentList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Person) != null  && this.DocumentNumber == (obj as Person).DocumentNumber;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.DocumentNumber).GetHashCode();
        }
    }
}
