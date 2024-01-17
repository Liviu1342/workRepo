using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System;
using System.Collections.Generic;

namespace CodedWfProcess_Cross_CS
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
            var codedWorkflow = new CodedWfProcess_Cross_CS.Workflow();
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