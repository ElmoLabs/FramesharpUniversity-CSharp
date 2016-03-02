
namespace FramesharpUniversity.WebApplication.Transcriptors
{
    public class PersonTranscriptor : Framework.Presentation.Web.Type.ModelDomainTranscriptor<Models.Person, Domain.Person>
    {
        public override Models.Person ConvertTo(Models.Person result, Domain.Person source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Person();
            }
            result.DocumentNumber = source.DocumentNumber;
            result.Name = source.Name;
            result.Gender = source.Gender;

            return result;
        }
        
        public override Domain.Person ConvertFrom(Models.Person source, Domain.Person result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Person();
            }
            result.DocumentNumber = source.DocumentNumber;
            result.Name = source.Name;
            result.Gender = source.Gender;

            return result;
        }
    }
}
