using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Process_Cross_VB_Complex_FixCompilation
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<Process_Cross_VB_Complex_FixCompilation.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        private Lazy<Library_Cross_VB_Complex.WorkflowRunnerService> _library_Cross_VB_ComplexLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService)};
            _workflowRunnerServiceLazy = new Lazy<Process_Cross_VB_Complex_FixCompilation.WorkflowRunnerService>(() => new Process_Cross_VB_Complex_FixCompilation.WorkflowRunnerService(this.services));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
            _library_Cross_VB_ComplexLazy = new Lazy<Library_Cross_VB_Complex.WorkflowRunnerService>(() => new Library_Cross_VB_Complex.WorkflowRunnerService(this.services));
        }

        protected Process_Cross_VB_Complex_FixCompilation.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
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

        protected Library_Cross_VB_Complex.WorkflowRunnerService library_Cross_VB_Complex => _library_Cross_VB_ComplexLazy.Value;
    }
}