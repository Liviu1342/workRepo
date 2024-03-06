using UiPath.CodedWorkflows;

namespace ArgumentProperties_Process_Win_VB
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