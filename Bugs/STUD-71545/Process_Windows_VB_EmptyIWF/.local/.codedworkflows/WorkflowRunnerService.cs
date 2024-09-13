using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Process_Windows_VB_EmptyIWF;

[assembly: WorkflowRunnerServiceAttribute(typeof(Process_Windows_VB_EmptyIWF.WorkflowRunnerService))]
namespace Process_Windows_VB_EmptyIWF
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Sequence.xaml
        /// </summary>
        public void Sequence()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Sequence.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the NonRelatedFlowchart.xaml
        /// </summary>
        public void NonRelatedFlowchart()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"NonRelatedFlowchart.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the NonRelatedSequence.xaml
        /// </summary>
        public void NonRelatedSequence()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"NonRelatedSequence.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invoker.xaml
        /// </summary>
        public void Invoker()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoker.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invoked.xaml
        /// </summary>
        public void Invoked()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
        public void Workflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflow.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}