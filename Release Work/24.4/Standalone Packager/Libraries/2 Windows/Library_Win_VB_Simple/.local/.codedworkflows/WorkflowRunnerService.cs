using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Library_Win_VB_Simple;

[assembly: WorkflowRunnerServiceAttribute(typeof(Library_Win_VB_Simple.WorkflowRunnerService))]
namespace Library_Win_VB_Simple
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Custom_LogMessage.xaml
        /// </summary>
        public void Custom_LogMessage(string in_Message)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Custom_LogMessage.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Coded/FootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void FootballTeam_Custom_Activity_Coded()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Coded\FootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}