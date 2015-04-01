using System.ServiceModel;
using FramesharpUniversity.Service.DataContracts;

namespace FramesharpUniversity.Service.Contracts
{
    [ServiceContract]
    public interface IDemonstrationService
    {
        [OperationContract]
        Demonstration GetDemonstration(int demonstrationId);
    }
}
