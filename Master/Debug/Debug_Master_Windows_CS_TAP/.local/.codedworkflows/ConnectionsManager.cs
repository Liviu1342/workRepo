using UiPath.CodedWorkflows;

namespace Debug_Master_Windows_CS_TAP
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