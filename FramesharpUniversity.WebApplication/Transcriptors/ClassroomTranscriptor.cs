
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class ClassroomTranscriptor
    {
        public Models.Classroom ConvertTo(Models.Classroom result, Domain.Classroom source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Classroom();
            }
            result.ClassroomId = source.ClassroomId;
            result.Name = source.Name;

            return result;
        }
        
        public Domain.Classroom ConvertFrom(Models.Classroom source, Domain.Classroom result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Classroom();
            }
            result.ClassroomId = source.ClassroomId;
            result.Name = source.Name;

            return result;
        }
    }
}
