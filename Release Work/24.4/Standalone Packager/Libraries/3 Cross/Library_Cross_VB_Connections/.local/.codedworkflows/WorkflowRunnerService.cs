using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Cross_VB_Connections
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the GitHub_CustomActivity.xaml
        /// </summary>
        public void GitHub_CustomActivity(string in_RepoName)
        {
            var result = _runWorkflowHandler(@"GitHub_CustomActivity.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}}, default, default, default);
        }

        /// <summary>
        /// Invokes the JIRA_Flowchart_CustomActivity.xaml
        /// </summary>
        public void JIRA_Flowchart_CustomActivity(string in_JiraIssue)
        {
            var result = _runWorkflowHandler(@"JIRA_Flowchart_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Outlook_CustomActivity.xaml
        /// </summary>
        public void Outlook_CustomActivity()
        {
            var result = _runWorkflowHandler(@"Outlook_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default);
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