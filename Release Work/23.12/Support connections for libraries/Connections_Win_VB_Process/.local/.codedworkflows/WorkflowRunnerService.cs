using Connections_Win_VB_Process.ObjectRepository;
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

namespace Connections_Win_VB_Process
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
        public void Workflow()
        {
            var result = _runWorkflowHandler(@"Workflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Sequence.xaml
        /// </summary>
        public void Sequence(System.String in_arg1, System.String in_arg2, System.String in_arg3)
        {
            var result = _runWorkflowHandler(@"Sequence.xaml", new Dictionary<string, object>{{"in_arg1", in_arg1}, {"in_arg2", in_arg2}, {"in_arg3", in_arg3}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Errors/CompilationError.xaml
        /// </summary>
        public void CompilationError(System.Data.DataTable in_Dt)
        {
            var result = _runWorkflowHandler(@"Errors\CompilationError.xaml", new Dictionary<string, object>{{"in_Dt", in_Dt}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Errors/Analyzer Error - High Argument Count.xaml
        /// </summary>
        public void Analyzer_Error___High_Argument_Count(System.String argument1, System.String argument2, System.String argument3, System.String argument4, System.String argument5, System.String argument6, System.String argument7, System.String argument8, System.String argument9, System.String argument10, System.String argument11, System.String argument12, System.String argument13, System.String argument14, System.String argument15, System.String argument16, System.String argument17, System.String argument18, System.String argument19, System.String argument20)
        {
            var result = _runWorkflowHandler(@"Errors\Analyzer Error - High Argument Count.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}, {"argument3", argument3}, {"argument4", argument4}, {"argument5", argument5}, {"argument6", argument6}, {"argument7", argument7}, {"argument8", argument8}, {"argument9", argument9}, {"argument10", argument10}, {"argument11", argument11}, {"argument12", argument12}, {"argument13", argument13}, {"argument14", argument14}, {"argument15", argument15}, {"argument16", argument16}, {"argument17", argument17}, {"argument18", argument18}, {"argument19", argument19}, {"argument20", argument20}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Errors/No Error.xaml
        /// </summary>
        public void No_Error(System.String argument1)
        {
            var result = _runWorkflowHandler(@"Errors\No Error.xaml", new Dictionary<string, object>{{"argument1", argument1}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Errors/Analyzer Error - Empty Catch Block.xaml
        /// </summary>
        public void Analyzer_Error___Empty_Catch_Block()
        {
            var result = _runWorkflowHandler(@"Errors\Analyzer Error - Empty Catch Block.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Errors/Validation Error.xaml
        /// </summary>
        public void Validation_Error()
        {
            var result = _runWorkflowHandler(@"Errors\Validation Error.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}