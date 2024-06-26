using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Library_Cross_VB_Complex;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace Library_Cross_VB_Complex
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Aggregator_CustomActivity.xaml
        /// </summary>
        public (string out_RepoFullName, int out_RepoId, string out_RepoName, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, Library_Cross_VB_Complex.CatEntity out_Cat, SwaggerPetstore.Pet out_PetId) Aggregator_CustomActivity(string in_RepoName, string in_JiraISsue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_Abc, System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Aggregator_CustomActivity.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraISsue", in_JiraISsue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_Abc", in_Abc}, {"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default, GetAssemblyName());
            return ((string)result["out_RepoFullName"], (int)result["out_RepoId"], (string)result["out_RepoName"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (Library_Cross_VB_Complex.CatEntity)result["out_Cat"], (SwaggerPetstore.Pet)result["out_PetId"]);
        }

        /// <summary>
        /// Invokes the Connections/MultipleConnections_CustomActivity.xaml
        /// </summary>
        public (UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields, string out_JiraId, string out_JiraKey) MultipleConnections_CustomActivity(string in_JiraIssue, System.Collections.Generic.IEnumerable<string> in_SendTo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\MultipleConnections_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}, {"in_SendTo", in_SendTo}}, default, default, default, GetAssemblyName());
            return ((UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"], (string)result["out_JiraId"], (string)result["out_JiraKey"]);
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public (int out_RepoId, UiPath.Jira.IntegrationService.Client.Curated_issueFields out_JiraFields) TestCase(string in_RepoName, string in_JiraISsue, System.Collections.Generic.IEnumerable<string> in_SendTo, string in_CatName, string in_Abc, System.Nullable<long> in_petId, string in_PetNAme)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestCase.xaml", new Dictionary<string, object>{{"in_RepoName", in_RepoName}, {"in_JiraISsue", in_JiraISsue}, {"in_SendTo", in_SendTo}, {"in_CatName", in_CatName}, {"in_Abc", in_Abc}, {"in_petId", in_petId}, {"in_PetNAme", in_PetNAme}}, default, default, default, GetAssemblyName());
            return ((int)result["out_RepoId"], (UiPath.Jira.IntegrationService.Client.Curated_issueFields)result["out_JiraFields"]);
        }

        /// <summary>
        /// Invokes the Webservice/Webservice_Pet_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.Pet Webservice_Pet_CustomActivity(System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Webservice\Webservice_Pet_CustomActivity.xaml", new Dictionary<string, object>{{"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default, GetAssemblyName());
            return (SwaggerPetstore.Pet)result["out_Pet"];
        }

        /// <summary>
        /// Invokes the Entities/Entities_CustomActivity.xaml
        /// </summary>
        public void Entities_CustomActivity(string in_CatName, string in_Arb, Library_Cross_VB_Complex.CatEntity out_Entity)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Entities\Entities_CustomActivity.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}, {"in_Arb", in_Arb}, {"out_Entity", out_Entity}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the UIA/OR_GoogleChrome_CustomActivity.xaml
        /// </summary>
        public void OR_GoogleChrome_CustomActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"UIA\OR_GoogleChrome_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
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