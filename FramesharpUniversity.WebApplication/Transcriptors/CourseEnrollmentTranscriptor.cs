
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class CourseEnrollmentTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.CourseEnrollment, Domain.CourseEnrollment>
    {
        public override Models.CourseEnrollment ConvertTo(Models.CourseEnrollment result, Domain.CourseEnrollment source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.CourseEnrollment();
            }
            result.CourseScheduleId = source.CourseScheduleId;
            result.StudentId = source.StudentId;

            return result;
        }
        
        public override Domain.CourseEnrollment ConvertFrom(Models.CourseEnrollment source, Domain.CourseEnrollment result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.CourseEnrollment();
            }
            result.CourseScheduleId = source.CourseScheduleId;
            result.StudentId = source.StudentId;

            return result;
        }
    }
}
