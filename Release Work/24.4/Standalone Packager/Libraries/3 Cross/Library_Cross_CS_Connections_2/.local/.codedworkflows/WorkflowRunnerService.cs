using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Library_Cross_CS_Connections_2;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

[assembly: WorkflowRunnerServiceAttribute(typeof(Library_Cross_CS_Connections_2.WorkflowRunnerService))]
namespace Library_Cross_CS_Connections_2
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the JIRA_CustomActivity.xaml
        /// </summary>
        public void JIRA_CustomActivity(string in_JiraIssue)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"JIRA_CustomActivity.xaml", new Dictionary<string, object>{{"in_JiraIssue", in_JiraIssue}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GitHub_CustomActivity.xaml
        /// </summary>
        public void GitHub_CustomActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GitHub_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Outlook_CustomActivity.xaml
        /// </summary>
        public void Outlook_CustomActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Outlook_CustomActivity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
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