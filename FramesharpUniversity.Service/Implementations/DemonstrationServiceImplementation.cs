using Framesharp.DomainService;
using Framesharp.ServiceModel;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Service.DataContracts;
using FramesharpUniversity.Service.Transcriptors;

namespace FramesharpUniversity.Service.Implementations
{
    public class DemonstrationServiceImplementation : ServiceBase
    {
        private readonly IDemonstrationDomainService demonstrationDomainService;

        public DemonstrationServiceImplementation()
        {
            this.demonstrationDomainService = DomainServiceFactory.Get<IDemonstrationDomainService>(this.OperationCallContext);
        }

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <param name="demonstrationId">Database identification number of the Demonstration instance</param>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        public Demonstration GetDemonstration(int demonstrationId)
        {
            Domain.Demonstration demonstrationDomain = this.demonstrationDomainService.GetDemonstration(demonstrationId);

            return DemonstrationTranscriptor.ConvertToDataContractFromDomain(demonstrationDomain);
        }
    }
}