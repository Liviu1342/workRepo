using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Collections.Generic;
using System.Data;
using L_VB_Windows_testSuite2310._5.ObjectRepository;
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
    public class TestCaseActivity : System.Activities.Activity
    {
        public InArgument<System.Collections.Generic.IDictionary<System.String, System.Object>> dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 { get; set; }

        public TestCaseActivity()
        {
            this.Implementation = () =>
            {
                return new TestCaseActivityChild()
                {dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 = (this.dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 == null ? (InArgument<System.Collections.Generic.IDictionary<System.String, System.Object>>)Argument.CreateReference((Argument)new InArgument<System.Collections.Generic.IDictionary<System.String, System.Object>>(), "dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2") : (InArgument<System.Collections.Generic.IDictionary<System.String, System.Object>>)Argument.CreateReference((Argument)this.dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2, "dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2")), };
            };
        }
    }

    internal class TestCaseActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.Collections.Generic.IDictionary<System.String, System.Object>> dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 { get; set; }

        public TestCaseActivityChild()
        {
            DisplayName = "TestCase";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 = dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2.Get(context);
            var codedWorkflow = new global::L_VB_Windows_testSuite2310._5.TestCase();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "TestCase.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                codedWorkflow.Execute(var_dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2);
                System.Collections.Generic.IDictionary<string, object> newResult = new System.Collections.Generic.Dictionary<string, object>{};
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "TestCase.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}