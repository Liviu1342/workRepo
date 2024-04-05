using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;
using Library_Win_VB_Complex.ObjectRepository;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.GSuite.Activities.Api;
using UiPath.Mail.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Library_Win_VB_Complex
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, string out_JiraId, string out_JiraKey, Library_Win_VB_Complex.CatEntity out_Cat, string out_CalculatorResult, SwaggerPetstore.User out_User) TestCase(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_FirstName, string in_LastName, string in_Username, string in_Password, string in_Email)
        {
            var result = _runWorkflowHandler(@"TestCase.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_FirstName", in_FirstName}, {"in_LastName", in_LastName}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default);
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (string)result["out_JiraId"], (string)result["out_JiraKey"], (Library_Win_VB_Complex.CatEntity)result["out_Cat"], (string)result["out_CalculatorResult"], (SwaggerPetstore.User)result["out_User"]);
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Webservice/Webservice_User_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.User Webservice_User_CustomActivity(SwaggerPetstore.User userBody, string in_FirstName, string in_LastNAme, string in_Username, string in_Password, string in_Email)
        {
            var result = _runWorkflowHandler(@"Webservice\Webservice_User_CustomActivity.xaml", new Dictionary<string, object>{{"userBody", userBody}, {"in_FirstName", in_FirstName}, {"in_LastNAme", in_LastNAme}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default);
            return (SwaggerPetstore.User)result["out_User"];
        }

        /// <summary>
        /// Invokes the UIA/OR_Calculator_CustomActivity.xaml
        /// </summary>
        public string OR_Calculator_CustomActivity()
        {
            var result = _runWorkflowHandler(@"UIA\OR_Calculator_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default);
            return (string)result["out_CalculatorResult"];
        }

        /// <summary>
        /// Invokes the Entities/Entities_CustomActivity.xaml
        /// </summary>
        public Library_Win_VB_Complex.CatEntity Entities_CustomActivity(string in_CatName)
        {
            var result = _runWorkflowHandler(@"Entities\Entities_CustomActivity.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}}, default, default, default);
            return (Library_Win_VB_Complex.CatEntity)result["out_Cat"];
        }

        /// <summary>
        /// Invokes the Connections/MultipleConnections_CustomActivity.xaml
        /// </summary>
        public (UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, string out_JiraId, string out_JiraKey) MultipleConnections_CustomActivity(string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo)
        {
            var result = _runWorkflowHandler(@"Connections\MultipleConnections_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}}, default, default, default);
            return ((UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (string)result["out_JiraId"], (string)result["out_JiraKey"]);
        }

        /// <summary>
        /// Invokes the Aggregator_CustomActivity.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, string out_JiraId, string out_JiraKey, Library_Win_VB_Complex.CatEntity out_Cat, string out_CalculatorResult, SwaggerPetstore.User out_User) Aggregator_CustomActivity(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_FirstName, string in_LastName, string in_Username, string in_Password, string in_Email)
        {
            var result = _runWorkflowHandler(@"Aggregator_CustomActivity.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_FirstName", in_FirstName}, {"in_LastName", in_LastName}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default);
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (string)result["out_JiraId"], (string)result["out_JiraKey"], (Library_Win_VB_Complex.CatEntity)result["out_Cat"], (string)result["out_CalculatorResult"], (SwaggerPetstore.User)result["out_User"]);
        }
    }
}