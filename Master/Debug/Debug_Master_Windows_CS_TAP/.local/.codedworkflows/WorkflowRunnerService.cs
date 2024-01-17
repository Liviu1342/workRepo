using Debug_Master_Windows_CS_TAP.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
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
using System.Threading.Tasks;
using UiPath.Activities.Contracts;

namespace Debug_Master_Windows_CS_TAP
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Entry Points/Entry Point 1.xaml
        /// </summary>
        public void Entry_Point_1(System.Collections.Generic.List<int> in_ErrorCodes)
        {
            var result = _runWorkflowHandler(@"Entry Points\Entry Point 1.xaml", new Dictionary<string, object>{{"in_ErrorCodes", in_ErrorCodes}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Retry.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Retry(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"Global Handlers\GlobalHandler-Retry.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Errors.xaml
        /// </summary>
        public void Errors(int in_ErrorCode)
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\Errors.xaml", new Dictionary<string, object>{{"in_ErrorCode", in_ErrorCode}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/File actions.xaml
        /// </summary>
        public void File_actions(string in_Filename, string in_OrchFolder, string in_OrchStorageBucketName, string in_TextForFile, string in_LocalFile)
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\File actions.xaml", new Dictionary<string, object>{{"in_Filename", in_Filename}, {"in_OrchFolder", in_OrchFolder}, {"in_OrchStorageBucketName", in_OrchStorageBucketName}, {"in_TextForFile", in_TextForFile}, {"in_LocalFile", in_LocalFile}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Continue.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Continue(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"Global Handlers\GlobalHandler-Continue.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Global Handlers/GlobalHandler-Ignore.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Ignore(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"Global Handlers\GlobalHandler-Ignore.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Orchestrator actions.xaml
        /// </summary>
        public void Orchestrator_actions(System.Collections.Generic.IEnumerable<UiPath.Core.QueueItem> out_QueueItems)
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\Orchestrator actions.xaml", new Dictionary<string, object>{{"out_QueueItems", out_QueueItems}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Loops.xaml
        /// </summary>
        public void Loops(int in_NoOfSteps, string BreakTriggerScopeInArgument, System.Collections.Generic.List<int> in_MyList)
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\Loops.xaml", new Dictionary<string, object>{{"in_NoOfSteps", in_NoOfSteps}, {"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}, {"in_MyList", in_MyList}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/UIA actions.xaml
        /// </summary>
        public string UIA_actions()
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\UIA actions.xaml", new Dictionary<string, object>{}, default, default, default);
            return (string)result["out_CalculatorResult"];
        }

        /// <summary>
        /// Invokes the Coded/Coded Wfs/PetActivity.cs
        /// </summary>
        public void PetActivity()
        {
            var result = _runWorkflowHandler(@"Coded\Coded Wfs\PetActivity.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/Collections.xaml
        /// </summary>
        public void Collections()
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\Collections.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Files to Use For Invoke/ConditionalBreakpoints-Test.xaml
        /// </summary>
        public void ConditionalBreakpoints_Test()
        {
            var result = _runWorkflowHandler(@"Files to Use For Invoke\ConditionalBreakpoints-Test.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}