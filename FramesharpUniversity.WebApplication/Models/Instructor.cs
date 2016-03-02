using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Instructor : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.Instructor(Instructor model)
		{
			return new Transcriptors.InstructorTranscriptor().ConvertFrom(model, new Domain.Instructor());
		}
		public static implicit operator Instructor(Domain.Instructor domain)
		{
			return new Transcriptors.InstructorTranscriptor().ConvertTo(new Instructor(), domain);
		}
        
        public Instructor()
        {
            this.CourseInstructorList = new List<CourseInstructor>();
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Instructor(System.Nullable<int> instructorId)
        {
            this.InstructorId = instructorId;
        }
        
        public virtual System.Nullable<int> InstructorId { get; set; }
        
        public virtual Person Person { get; set; }
        
        [Display(Name = "AdmissionDate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual System.DateTime AdmissionDate { get; set; }
        
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
