using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Win_CS_Connections
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
        public (string out_ReleaseUrl, int out_RepoId, string out_RepoName, UiPath.GitHub.IntegrationService.Client.ReposSource out_Source, string out_TagsUrl) GitHub_CustomActivity(string in_Repository)
        {
            var result = _runWorkflowHandler(@"GitHub_CustomActivity.xaml", new Dictionary<string, object>{{"in_Repository", in_Repository}}, default, default, default);
            return ((string)result["out_ReleaseUrl"], (int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.GitHub.IntegrationService.Client.ReposSource)result["out_Source"], (string)result["out_TagsUrl"]);
        }

        /// <summary>
        /// Invokes the Jira_CustomActivity.xaml
        /// </summary>
        public (UiPath.Jira.IntegrationService.Client.Curated_issueFields fields, string out_issueId) Jira_CustomActivity(string in_JiraIssue)
        {
            var result = _runWorkflowHandler(@"Jira_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}}, default, default, default);
            return ((UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["fields"], (string)result["out_issueId"]);
        }

        /// <summary>
        /// Invokes the Outlook_CustomActivity.xaml
        /// </summary>
        public void Outlook_CustomActivity(string in_ErrorMessage, System.Collections.Generic.List<UiPath.MicrosoftOffice365.Models.Office365Message> out_emailList)
        {
            var result = _runWorkflowHandler(@"Outlook_CustomActivity.xaml", new Dictionary<string, object>{{"in_ErrorMessage", in_ErrorMessage}, {"out_emailList", out_emailList}}, default, default, default);
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