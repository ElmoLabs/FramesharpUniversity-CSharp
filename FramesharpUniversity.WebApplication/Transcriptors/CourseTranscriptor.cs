
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class CourseTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.Course, Domain.Course>
    {
        public override Models.Course ConvertTo(Models.Course result, Domain.Course source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Course();
            }
            result.CourseId = source.CourseId;
            result.Name = source.Name;
            result.Description = source.Description;

            return result;
        }
        
        public override Domain.Course ConvertFrom(Models.Course source, Domain.Course result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Course();
            }
            result.CourseId = source.CourseId;
            result.Name = source.Name;
            result.Description = source.Description;

            return result;
        }
    }
}
