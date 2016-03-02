using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Classroom
    {
		public static implicit operator Domain.Classroom(Classroom model)
		{
			return Transcriptors.ClassroomTranscriptor.(model, new Domain.Classroom());
		}
		public static implicit operator Classroom(Domain.Classroom domain)
		{
			return Transcriptors.ClassroomTranscriptor.(new Classroom(), domain);
		}
        
        public Classroom()
        {
            this.CourseScheduleList = new List<CourseSchedule>();
        }
        
        public Classroom(System.Nullable<int> classroomId)
        {
            this.ClassroomId = classroomId;
        }
        
        public virtual System.Nullable<int> ClassroomId { get; set; }
        
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        [MaxLength(50)]
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
