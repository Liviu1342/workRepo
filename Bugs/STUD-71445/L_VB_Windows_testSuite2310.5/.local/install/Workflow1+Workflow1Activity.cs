using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using L_VB_Windows_testSuite2310._5.ObjectRepository;
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

namespace L_VB_Windows_testSuite2310._5
{
    public class Workflow1Activity : System.Activities.Activity
    {
        public Workflow1Activity()
        {
            this.Implementation = () =>
            {
                return new Workflow1ActivityChild()
                {};
            };
        }
    }

    internal class Workflow1ActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public Workflow1ActivityChild()
        {
            DisplayName = "Workflow1";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::L_VB_Windows_testSuite2310._5.Workflow1();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Workflow1.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                codedWorkflow.Execute();
                System.Collections.Generic.IDictionary<string, object> newResult = new System.Collections.Generic.Dictionary<string, object>{};
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Workflow1.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}