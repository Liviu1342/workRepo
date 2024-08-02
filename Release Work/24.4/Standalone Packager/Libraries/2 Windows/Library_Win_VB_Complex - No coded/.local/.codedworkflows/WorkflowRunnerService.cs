using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Library_Win_VB_Complex;

[assembly: WorkflowRunnerServiceAttribute(typeof(Library_Win_VB_Complex.WorkflowRunnerService))]
namespace Library_Win_VB_Complex
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Webservice/Webservice_User_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.User Webservice_User_CustomActivity(SwaggerPetstore.User userBody, string in_FirstName, string in_LastNAme, string in_Username, string in_Password, string in_Email)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Webservice\Webservice_User_CustomActivity.xaml", new Dictionary<string, object>{{"userBody", userBody}, {"in_FirstName", in_FirstName}, {"in_LastNAme", in_LastNAme}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default, GetAssemblyName());
            return (SwaggerPetstore.User)result["out_User"];
        }

        /// <summary>
        /// Invokes the Connections/MultipleConnections_CustomActivity.xaml
        /// </summary>
        public (UiPath.IntegrationService.Activities.SWEntities.C2AAC668FCD_repos.Bundle.repos out_GitHub_Repo, UiPath.GSuite.Models.GmailMessage out_Email) MultipleConnections_CustomActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\MultipleConnections_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((UiPath.IntegrationService.Activities.SWEntities.C2AAC668FCD_repos.Bundle.repos)result["out_GitHub_Repo"], (UiPath.GSuite.Models.GmailMessage)result["out_Email"]);
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, string out_JiraId, string out_JiraKey, string out_CalculatorResult) TestCase(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_FirstName, string in_LastName, string in_Username, string in_Password, string in_Email)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestCase.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_FirstName", in_FirstName}, {"in_LastName", in_LastName}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default, GetAssemblyName());
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (string)result["out_JiraId"], (string)result["out_JiraKey"], (string)result["out_CalculatorResult"]);
        }

        /// <summary>
        /// Invokes the Aggregator_CustomActivity.xaml
        /// </summary>
        public (int out_RepoId, string out_RepoName, string out_JiraId, string out_JiraKey, string out_CalculatorResult) Aggregator_CustomActivity(string in_RepoName, string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_FirstName, string in_LastName, string in_Username, string in_Password, string in_Email)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Aggregator_CustomActivity.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_FirstName", in_FirstName}, {"in_LastName", in_LastName}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default, GetAssemblyName());
            return ((int)result["out_RepoId"], (string)result["out_RepoName"], (string)result["out_JiraId"], (string)result["out_JiraKey"], (string)result["out_CalculatorResult"]);
        }

        /// <summary>
        /// Invokes the Entities/Entities_CustomActivity.xaml
        /// </summary>
        public Library_Win_VB_Complex.CatEntity Entities_CustomActivity(string in_CatName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Entities\Entities_CustomActivity.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}}, default, default, default, GetAssemblyName());
            return (Library_Win_VB_Complex.CatEntity)result["out_Cat"];
        }

        /// <summary>
        /// Invokes the UIA/OR_Calculator_CustomActivity.xaml
        /// </summary>
        public string OR_Calculator_CustomActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"UIA\OR_Calculator_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["out_CalculatorResult"];
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}