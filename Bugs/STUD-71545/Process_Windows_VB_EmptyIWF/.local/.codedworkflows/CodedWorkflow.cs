using System;
using UiPath.CodedWorkflows;

namespace Process_Windows_VB_EmptyIWF
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<Process_Windows_VB_EmptyIWF.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]{};
            _workflowRunnerServiceLazy = new Lazy<Process_Windows_VB_EmptyIWF.WorkflowRunnerService>(() => new Process_Windows_VB_EmptyIWF.WorkflowRunnerService(this.services));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
        }

        protected Process_Windows_VB_EmptyIWF.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
    }
}