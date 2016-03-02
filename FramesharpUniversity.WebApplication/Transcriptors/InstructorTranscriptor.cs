
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class InstructorTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.Instructor, Domain.Instructor>
    {
        public override Models.Instructor ConvertTo(Models.Instructor result, Domain.Instructor source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Instructor();
            }
            result.InstructorId = source.InstructorId;
            result.AdmissionDate = source.AdmissionDate;

            return result;
        }
        
        public override Domain.Instructor ConvertFrom(Models.Instructor source, Domain.Instructor result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Instructor();
            }
            result.InstructorId = source.InstructorId;
            result.AdmissionDate = source.AdmissionDate;

            return result;
        }
    }
}
