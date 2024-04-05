using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;

namespace ArgumentProperties_Process_Win_VB.EntryPoints
{
    public class EP5_CodedWorkflowActivity : System.Activities.Activity
    {
        public InArgument<System.String> arg1 { get; set; }

        public EP5_CodedWorkflowActivity()
        {
            this.Implementation = () =>
            {
                return new EP5_CodedWorkflowActivityChild()
                {arg1 = (this.arg1 == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "arg1") : (InArgument<System.String>)Argument.CreateReference((Argument)this.arg1, "arg1")), };
            };
        }
    }

    internal class EP5_CodedWorkflowActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> arg1 { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public EP5_CodedWorkflowActivityChild()
        {
            DisplayName = "EP5_CodedWorkflow";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var var_arg1 = arg1.Get(context);
            var codedWorkflow = new global::ArgumentProperties_Process_Win_VB.EntryPoints.EP5_CodedWorkflow();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Entry Points\\EP5_CodedWorkflow.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        codedWorkflow.Execute(var_arg1);
                        newResult = new System.Collections.Generic.Dictionary<string, object>{};
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Entry Points\\EP5_CodedWorkflow.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}