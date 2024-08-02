using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Library_Cross_VB_Simple
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<Library_Cross_VB_Simple.WorkflowRunnerService> _workflowRunnerServiceLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
            _workflowRunnerServiceLazy = new Lazy<Library_Cross_VB_Simple.WorkflowRunnerService>(() => new Library_Cross_VB_Simple.WorkflowRunnerService(this.RunWorkflow));
        }

        protected Library_Cross_VB_Simple.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
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