using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
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

namespace Debug_Master_Windows_CS_TAP.Coded.CodedWfs
{
    public class TestCase_CodedActivity : System.Activities.Activity
    {
        public TestCase_CodedActivity()
        {
            this.Implementation = () =>
            {
                return new TestCase_CodedActivityChild()
                {};
            };
        }
    }

    internal class TestCase_CodedActivityChild : CodeActivity
    {
        public TestCase_CodedActivityChild()
        {
            DisplayName = "TestCase_Coded";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new global::Debug_Master_Windows_CS_TAP.CodedWfs.TestCase_Coded();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Coded\\Coded Wfs\\TestCase-Coded.cs"});
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
                    {RelativeFilePath = "Coded\\Coded Wfs\\TestCase-Coded.cs", Exception = exception});
                }
            });
        }
    }
}