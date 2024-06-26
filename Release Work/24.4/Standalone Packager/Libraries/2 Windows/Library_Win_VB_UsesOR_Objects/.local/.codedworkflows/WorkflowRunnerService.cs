using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Win_VB_UsesOR_Objects
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the GoogleChrome_CustomActivity.xaml
        /// </summary>
        public void GoogleChrome_CustomActivity(string in_Prompt, double in_HighlightDuration)
        {
            var result = _runWorkflowHandler(@"GoogleChrome_CustomActivity.xaml", new Dictionary<string, object>{{"in_Prompt", in_Prompt}, {"in_HighlightDuration", in_HighlightDuration}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Calculator_CustomActivity.xaml
        /// </summary>
        public string Calculator_CustomActivity()
        {
            var result = _runWorkflowHandler(@"Calculator_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default);
            return (string)result["out_Result"];
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }
    }
}