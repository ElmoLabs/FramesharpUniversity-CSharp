using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Course : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.Course(Course model)
		{
			return new Transcriptors.CourseTranscriptor().ConvertFrom(model, new Domain.Course());
		}
		public static implicit operator Course(Domain.Course domain)
		{
			return new Transcriptors.CourseTranscriptor().ConvertTo(new Course(), domain);
		}
        
        public Course()
        {
            this.CourseInstructorList = new List<CourseInstructor>();
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Course(System.Nullable<int> courseId)
        {
            this.CourseId = courseId;
        }
        
        public virtual System.Nullable<int> CourseId { get; set; }
        
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        [MaxLength(50)]
        public virtual string Name { get; set; }
        
        [Display(Name = "Description")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        [MaxLength(200)]
        public virtual string Description { get; set; }
        
        public virtual IList<CourseInstructor> CourseInstructorList { get; set; }
        
        public virtual IList<CourseSchedule> CourseScheduleList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as Course) != null  && this.CourseId == (obj as Course).CourseId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseId).GetHashCode();
        }
    }
}
