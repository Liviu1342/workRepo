using UiPath.CodedWorkflows;

namespace Location_Constant_in_CodedWf_Library_VB
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