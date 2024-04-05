using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Cross_CS_Connections
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
        public (string fullName, int repositoryId) GitHub_CustomActivity(string in_Repository)
        {
            var result = _runWorkflowHandler(@"GitHub_CustomActivity.xaml", new Dictionary<string, object>{{"in_Repository", in_Repository}}, default, default, default);
            return ((string)result["fullName"], (int)result["repositoryId"]);
        }

        /// <summary>
        /// Invokes the JIRA_CustomActivity.xaml
        /// </summary>
        public UiPath.Jira.IntegrationService.Client.Curated_issueFields JIRA_CustomActivity(string in_JiraIssue)
        {
            var result = _runWorkflowHandler(@"JIRA_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}}, default, default, default);
            return (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["fields"];
        }

        /// <summary>
        /// Invokes the Outlook_CustomActivity.xaml
        /// </summary>
        public System.Collections.Generic.List<UiPath.MicrosoftOffice365.Models.Office365Message> Outlook_CustomActivity(object in_ErrorMessage)
        {
            var result = _runWorkflowHandler(@"Outlook_CustomActivity.xaml", new Dictionary<string, object>{{"in_ErrorMessage", in_ErrorMessage}}, default, default, default);
            return (System.Collections.Generic.List<UiPath.MicrosoftOffice365.Models.Office365Message>)result["out_emailList"];
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