using System.ServiceModel;

namespace YourNamespace
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        void ProcessUser(User user);
    }
}
