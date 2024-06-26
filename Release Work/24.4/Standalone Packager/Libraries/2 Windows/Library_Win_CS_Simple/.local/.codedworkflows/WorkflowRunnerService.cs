using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Library_Win_CS_Simple;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace Library_Win_CS_Simple
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the MessageBox_CustomActivity.xaml
        /// </summary>
        public void MessageBox_CustomActivity(string in_Message)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"MessageBox_CustomActivity.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default, GetAssemblyName());
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