
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class CourseInstructorTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.CourseInstructor, Domain.CourseInstructor>
    {
        public override Models.CourseInstructor ConvertTo(Models.CourseInstructor result, Domain.CourseInstructor source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.CourseInstructor();
            }
            result.CourseId = source.CourseId;
            result.InstructorId = source.InstructorId;

            return result;
        }
        
        public override Domain.CourseInstructor ConvertFrom(Models.CourseInstructor source, Domain.CourseInstructor result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.CourseInstructor();
            }
            result.CourseId = source.CourseId;
            result.InstructorId = source.InstructorId;

            return result;
        }
    }
}
