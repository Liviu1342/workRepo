using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.GSuite.Activities.Api;
using UiPath.Mail.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Connections_Win_VB_Process
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<Connections_Win_VB_Process.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.GSuite.Activities.Api.IGoogleConnectionsService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService), typeof(UiPath.Mail.Activities.Api.IMailService)};
            _workflowRunnerServiceLazy = new Lazy<Connections_Win_VB_Process.WorkflowRunnerService>(() => new Connections_Win_VB_Process.WorkflowRunnerService(this.RunWorkflow));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
        }

        protected Connections_Win_VB_Process.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
#pragma warning disable
        protected UiPath.GSuite.Activities.Api.IGoogleConnectionsService google { get => serviceContainer.Resolve<UiPath.GSuite.Activities.Api.IGoogleConnectionsService>() ; }
#pragma warning restore

#pragma warning disable
        protected UiPath.Mail.Activities.Api.IMailService mail { get => serviceContainer.Resolve<UiPath.Mail.Activities.Api.IMailService>() ; }
#pragma warning restore

#pragma warning disable
        protected UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService office365 { get => serviceContainer.Resolve<UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService>() ; }
#pragma warning restore

#pragma warning disable
        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>() ; }
#pragma warning restore

#pragma warning disable
        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>() ; }
#pragma warning restore

#pragma warning disable
        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>() ; }
#pragma warning restore
    }
}