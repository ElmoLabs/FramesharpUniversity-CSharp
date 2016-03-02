
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class StudentTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.Student, Domain.Student>
    {
        public override Models.Student ConvertTo(Models.Student result, Domain.Student source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Student();
            }
            result.StudentId = source.StudentId;
            result.EnrollmentDate = source.EnrollmentDate;

            return result;
        }
        
        public override Domain.Student ConvertFrom(Models.Student source, Domain.Student result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Student();
            }
            result.StudentId = source.StudentId;
            result.EnrollmentDate = source.EnrollmentDate;

            return result;
        }
    }
}
