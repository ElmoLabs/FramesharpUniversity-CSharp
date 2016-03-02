using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FramesharpUniversity.Domain;

namespace FramesharpUniversity.WebApplication.Models
{
    public class Person : Framesharp.Presentation.Web.Mvc.Models.ModelBase, Framesharp.Presentation.Web.Mvc.Models.IModel
    {
		public static implicit operator Domain.Person(Person model)
		{
			return new Transcriptors.PersonTranscriptor().ConvertFrom(model, new Domain.Person());
		}
		public static implicit operator Person(Domain.Person domain)
		{
			return new Transcriptors.PersonTranscriptor().ConvertTo(new Person(), domain);
		}
        
        public Person()
        {
            this.InstructorList = new List<Instructor>();
            this.StudentList = new List<Student>();
        }
        
        public Person(System.Nullable<long> documentNumber)
        {
            this.DocumentNumber = documentNumber;
        }
        
        public virtual System.Nullable<long> DocumentNumber { get; set; }
        
        [Display(Name = "Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        [MaxLength(200)]
        public virtual string Name { get; set; }
        
        [Display(Name = "Gender")]
        [Required(AllowEmptyStrings = false, ErrorMessage = @"O campo {0} é obrigatório.")]
        [MaxLength(1)]
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
