
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class CourseScheduleTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.CourseSchedule, Domain.CourseSchedule>
    {
        public override Models.CourseSchedule ConvertTo(Models.CourseSchedule result, Domain.CourseSchedule source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.CourseSchedule();
            }
            result.CourseScheduleId = source.CourseScheduleId;
            result.CourseId = source.CourseId;
            result.InstructorId = source.InstructorId;
            result.ClassroomId = source.ClassroomId;
            result.StartingHour = source.StartingHour;
            result.StartingMinute = source.StartingMinute;
            result.FinshingHour = source.FinshingHour;
            result.FinshingMinute = source.FinshingMinute;

            return result;
        }
        
        public override Domain.CourseSchedule ConvertFrom(Models.CourseSchedule source, Domain.CourseSchedule result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.CourseSchedule();
            }
            result.CourseScheduleId = source.CourseScheduleId;
            result.CourseId = source.CourseId;
            result.InstructorId = source.InstructorId;
            result.ClassroomId = source.ClassroomId;
            result.StartingHour = source.StartingHour;
            result.StartingMinute = source.StartingMinute;
            result.FinshingHour = source.FinshingHour;
            result.FinshingMinute = source.FinshingMinute;

            return result;
        }
    }
}
