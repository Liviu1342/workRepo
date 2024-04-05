using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;
using Library_Win_CS_Complex.ObjectRepository;
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

namespace Library_Win_CS_Complex
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Aggregator_CustomActivity.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, Library_Win_CS_Complex.CatEntity out_Cat, string out_CalculatorResult, SwaggerPetstore.Pet out_Pet) Aggregator_CustomActivity(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatNAme, System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _runWorkflowHandler(@"Aggregator_CustomActivity.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatNAme", in_CatNAme}, {"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default);
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (Library_Win_CS_Complex.CatEntity)result["out_Cat"], (string)result["out_CalculatorResult"], (SwaggerPetstore.Pet)result["out_Pet"]);
        }

        /// <summary>
        /// Invokes the Connections/MultipleConnections_CustomActivity.xaml
        /// </summary>
        public (UiPath.Jira.IntegrationService.Client.Curated_issueFields out_Fields, string out_IssueId) MultipleConnections_CustomActivity(string in_JiraIssue, string out_IssueKey, System.Collections.Generic.IEnumerable<string> in_SendTo)
        {
            var result = _runWorkflowHandler(@"Connections\MultipleConnections_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}, {"out_IssueKey", out_IssueKey}, {"in_SendTo", in_SendTo}}, default, default, default);
            return ((UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_Fields"], (string)result["out_IssueId"]);
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, Library_Win_CS_Complex.CatEntity out_Cat, string out_CalculatorResult, SwaggerPetstore.Pet out_Pet) TestCase(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatNAme, System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _runWorkflowHandler(@"TestCase.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatNAme", in_CatNAme}, {"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default);
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (Library_Win_CS_Complex.CatEntity)result["out_Cat"], (string)result["out_CalculatorResult"], (SwaggerPetstore.Pet)result["out_Pet"]);
        }

        /// <summary>
        /// Invokes the Webservice/Webservice_Pet_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.Pet Webservice_Pet_CustomActivity(System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _runWorkflowHandler(@"Webservice\Webservice_Pet_CustomActivity.xaml", new Dictionary<string, object>{{"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default);
            return (SwaggerPetstore.Pet)result["out_Pet"];
        }

        /// <summary>
        /// Invokes the Entities/Entities_CustomActivity.xaml
        /// </summary>
        public Library_Win_CS_Complex.CatEntity Entities_CustomActivity(string in_CatName)
        {
            var result = _runWorkflowHandler(@"Entities\Entities_CustomActivity.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}}, default, default, default);
            return (Library_Win_CS_Complex.CatEntity)result["out_Cat"];
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
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }
    }
}