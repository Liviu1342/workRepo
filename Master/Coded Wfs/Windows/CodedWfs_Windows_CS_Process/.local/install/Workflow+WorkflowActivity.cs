using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using CodedWfs_Windows_CS_Process.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace CodedWfs_Windows_CS_Process
{
    public class WorkflowActivity : System.Activities.Activity
    {
        public WorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new WorkflowActivityChild()
                {};
            };
        }
    }

    internal class WorkflowActivityChild : CodeActivity
    {
        public WorkflowActivityChild()
        {
            DisplayName = "Workflow";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new global::CodedWfs_Windows_CS_Process.Workflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Workflow.cs"});
                }
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Workflow.cs", Exception = exception});
                }
            });
        }
    }
}