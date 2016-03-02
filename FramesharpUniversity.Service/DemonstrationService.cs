using FramesharpUniversity.Service.Contracts;
using FramesharpUniversity.Service.DataContracts;
using FramesharpUniversity.Service.Implementations;

namespace FramesharpUniversity.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DemonstrationService : IDemonstrationService
    {
        private readonly DemonstrationServiceImplementation serviceImplementation;

        public DemonstrationService()
        {
            this.serviceImplementation = new DemonstrationServiceImplementation();
        }

        public Demonstration GetDemonstration(int demonstrationId)
        {
            return this.serviceImplementation.GetDemonstration(demonstrationId);
        }
    }
}
