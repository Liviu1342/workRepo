using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using CodedWfs_Windows_VB_Process.ObjectRepository;
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

namespace CodedWfs_Windows_VB_Process_Tests
{
    public class CodedWorkflow1Activity : System.Activities.Activity
    {
        public CodedWorkflow1Activity()
        {
            this.Implementation = () =>
            {
                return new CodedWorkflow1ActivityChild()
                {};
            };
        }
    }

    internal class CodedWorkflow1ActivityChild : CodeActivity
    {
        public CodedWorkflow1ActivityChild()
        {
            DisplayName = "CodedWorkflow1";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new global::CodedWfs_Windows_VB_Process.CodedWorkflow1();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "CodedWorkflow1.cs"});
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
                    {RelativeFilePath = "CodedWorkflow1.cs", Exception = exception});
                }
            });
        }
    }
}