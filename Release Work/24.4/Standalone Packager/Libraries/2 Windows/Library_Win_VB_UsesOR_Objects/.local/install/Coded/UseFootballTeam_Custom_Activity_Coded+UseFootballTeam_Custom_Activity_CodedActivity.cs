using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;

namespace Library_Win_VB_UsesOR_Objects.Coded
{
    public class UseFootballTeam_Custom_Activity_CodedActivity : System.Activities.Activity
    {
        public UseFootballTeam_Custom_Activity_CodedActivity()
        {
            this.Implementation = () =>
            {
                return new UseFootballTeam_Custom_Activity_CodedActivityChild()
                {};
            };
        }
    }

    internal class UseFootballTeam_Custom_Activity_CodedActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public UseFootballTeam_Custom_Activity_CodedActivityChild()
        {
            DisplayName = "UseFootballTeam_Custom_Activity_Coded";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::Library_Win_VB_UsesOR_Objects.Coded.UseFootballTeam_Custom_Activity_Coded();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Coded\\UseFootballTeam_Custom_Activity_Coded.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        codedWorkflow.Execute();
                        newResult = new System.Collections.Generic.Dictionary<string, object>{};
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Coded\\UseFootballTeam_Custom_Activity_Coded.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
            };
        }
    }
}