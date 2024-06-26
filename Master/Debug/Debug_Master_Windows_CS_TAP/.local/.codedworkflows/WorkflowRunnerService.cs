using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Debug_Master_Windows_CS_TAP;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace Debug_Master_Windows_CS_TAP
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/File actions.xaml
        /// </summary>
        public void File_actions(string in_Filename, string in_OrchFolder, string in_OrchStorageBucketName, string in_TextForFile, string in_LocalFile)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\File actions.xaml", new Dictionary<string, object>{{"in_Filename", in_Filename}, {"in_OrchFolder", in_OrchFolder}, {"in_OrchStorageBucketName", in_OrchStorageBucketName}, {"in_TextForFile", in_TextForFile}, {"in_LocalFile", in_LocalFile}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Entry Points/Entry Point 1.xaml
        /// </summary>
        public void Entry_Point_1(System.Collections.Generic.List<int> in_ErrorCodes)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Entry Points\Entry Point 1.xaml", new Dictionary<string, object>{{"in_ErrorCodes", in_ErrorCodes}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Loops.xaml
        /// </summary>
        public void Loops(int in_NoOfSteps, string BreakTriggerScopeInArgument, System.Collections.Generic.List<int> in_MyList)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\Loops.xaml", new Dictionary<string, object>{{"in_NoOfSteps", in_NoOfSteps}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"in_MyList", in_MyList}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Orchestrator actions.xaml
        /// </summary>
        public void Orchestrator_actions(System.Collections.Generic.IEnumerable<UiPath.Core.QueueItem> out_QueueItems)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\Orchestrator actions.xaml", new Dictionary<string, object>{{"out_QueueItems", out_QueueItems}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Collections.xaml
        /// </summary>
        public void Collections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\Collections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Ignore.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Ignore(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Global Handlers\GlobalHandler-Ignore.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Errors.xaml
        /// </summary>
        public void Errors(int in_ErrorCode, UiPath.Core.Activities.GlobalVariableTriggerArgs TriggerEventArgs)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\Errors.xaml", new Dictionary<string, object>{{"in_ErrorCode", in_ErrorCode}, {"TriggerEventArgs", TriggerEventArgs}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/UIA actions.xaml
        /// </summary>
        public string UIA_actions()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\UIA actions.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["out_CalculatorResult"];
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Retry.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Retry(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Global Handlers\GlobalHandler-Retry.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Continue.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Continue(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Global Handlers\GlobalHandler-Continue.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the TestCase.xaml
        /// </summary>
        public void TestCase(string in_Message)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TestCase.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/ConditionalBreakpoints-Test.xaml
        /// </summary>
        public void ConditionalBreakpoints_Test()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Files to Use For Invoke\ConditionalBreakpoints-Test.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Coded/Coded Wfs/PetActivity.cs
        /// </summary>
        public void PetActivity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Coded\Coded Wfs\PetActivity.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}