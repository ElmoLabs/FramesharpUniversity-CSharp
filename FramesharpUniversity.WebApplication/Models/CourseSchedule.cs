using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class CourseSchedule : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.CourseSchedule(CourseSchedule model)
		{
			return new Transcriptors.CourseScheduleTranscriptor().ConvertFrom(model, new Domain.CourseSchedule());
		}
		public static implicit operator CourseSchedule(Domain.CourseSchedule domain)
		{
			return new Transcriptors.CourseScheduleTranscriptor().ConvertTo(new CourseSchedule(), domain);
		}
        
        public CourseSchedule()
        {
            this.CourseEnrollmentList = new List<CourseEnrollment>();
        }
        
        public CourseSchedule(System.Nullable<int> courseScheduleId)
        {
            this.CourseScheduleId = courseScheduleId;
        }
        
        public virtual System.Nullable<int> CourseScheduleId { get; set; }
        
        public virtual Course Course { get; set; }
        
        public virtual Instructor Instructor { get; set; }
        
        public virtual Classroom Classroom { get; set; }
        
        [Display(Name = "CourseId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual int CourseId { get; set; }
        
        [Display(Name = "InstructorId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual int InstructorId { get; set; }
        
        [Display(Name = "ClassroomId")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual int ClassroomId { get; set; }
        
        [Display(Name = "StartingHour")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual byte StartingHour { get; set; }
        
        [Display(Name = "StartingMinute")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual byte StartingMinute { get; set; }
        
        [Display(Name = "FinshingHour")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual byte FinshingHour { get; set; }
        
        [Display(Name = "FinshingMinute")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        public virtual byte FinshingMinute { get; set; }
        
        public virtual IList<CourseEnrollment> CourseEnrollmentList { get; set; }
        
        public override bool Equals(object obj)
        {
			return (obj as CourseSchedule) != null  && this.CourseScheduleId == (obj as CourseSchedule).CourseScheduleId;
        }
        
        public override int GetHashCode()
        {
			return string.Concat(this.CourseScheduleId).GetHashCode();
        }
    }
}
