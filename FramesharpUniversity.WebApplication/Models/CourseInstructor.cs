using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class CourseInstructor : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.CourseInstructor(CourseInstructor model)
		{
			return new Transcriptors.CourseInstructorTranscriptor().ConvertFrom(model, new Domain.CourseInstructor());
		}
		public static implicit operator CourseInstructor(Domain.CourseInstructor domain)
		{
			return new Transcriptors.CourseInstructorTranscriptor().ConvertTo(new CourseInstructor(), domain);
		}
        
        public CourseInstructor()
        { }
        
        public CourseInstructor(System.Nullable<int> courseId, System.Nullable<int> instructorId)
        {
            this.CourseId = courseId;
            this.InstructorId = instructorId;
        }
        
        public virtual System.Nullable<int> CourseId { get; set; }
        
        public virtual System.Nullable<int> InstructorId { get; set; }
        
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
