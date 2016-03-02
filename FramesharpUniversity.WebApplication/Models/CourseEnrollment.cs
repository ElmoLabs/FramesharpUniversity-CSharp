using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class CourseEnrollment : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.CourseEnrollment(CourseEnrollment model)
		{
			return new Transcriptors.CourseEnrollmentTranscriptor().ConvertFrom(model, new Domain.CourseEnrollment());
		}
		public static implicit operator CourseEnrollment(Domain.CourseEnrollment domain)
		{
			return new Transcriptors.CourseEnrollmentTranscriptor().ConvertTo(new CourseEnrollment(), domain);
		}
        
        public CourseEnrollment()
        { }
        
        public CourseEnrollment(System.Nullable<int> courseScheduleId, System.Nullable<int> studentId)
        {
            this.CourseScheduleId = courseScheduleId;
            this.StudentId = studentId;
        }
        
        public virtual System.Nullable<int> CourseScheduleId { get; set; }
        
        public virtual System.Nullable<int> StudentId { get; set; }
        
        public virtual CourseSchedule CourseSchedule { get; set; }
        
        public virtual Student Student { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as CourseEnrollment) != null  && this.CourseScheduleId == (obj as CourseEnrollment).CourseScheduleId && this.StudentId == (obj as CourseEnrollment).StudentId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseScheduleId, this.StudentId).GetHashCode();
        }
    }
}
