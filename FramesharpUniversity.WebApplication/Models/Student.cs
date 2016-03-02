using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Student : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.Student(Student model)
		{
			return new Transcriptors.StudentTranscriptor().ConvertFrom(model, new Domain.Student());
		}
		public static implicit operator Student(Domain.Student domain)
		{
			return new Transcriptors.StudentTranscriptor().ConvertTo(new Student(), domain);
		}
        
        public Student()
        {
            this.CourseEnrollmentList = new List<CourseEnrollment>();
        }
        
        public Student(System.Nullable<int> studentId)
        {
            this.StudentId = studentId;
        }
        
        public virtual System.Nullable<int> StudentId { get; set; }
        
        public virtual Person Person { get; set; }
        
        [Display(Name = "EnrollmentDate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual System.DateTime EnrollmentDate { get; set; }
        
        public virtual IList<CourseEnrollment> CourseEnrollmentList { get; set; }
        
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
