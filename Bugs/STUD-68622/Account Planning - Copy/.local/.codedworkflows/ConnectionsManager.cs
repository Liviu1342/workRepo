using UiPath.CodedWorkflows;

namespace GetInformationForCompany
{
    public class ConnectionsManager
    {
        private ICodedWorkflowsServiceContainer _resolver;
        public ConnectionsManager(ICodedWorkflowsServiceContainer resolver)
        {
            _resolver = resolver;
        }
    }
}