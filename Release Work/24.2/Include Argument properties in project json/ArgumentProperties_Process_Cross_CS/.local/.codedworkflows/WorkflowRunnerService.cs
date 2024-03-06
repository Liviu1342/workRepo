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

namespace ArgumentProperties_Process_Cross_CS
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the EP5_CodedWorkflow.cs
        /// </summary>
        public void EP5_CodedWorkflow()
        {
            var result = _runWorkflowHandler(@"EP5_CodedWorkflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP6_CodedWorkflow.cs
        /// </summary>
        public void NEP6_CodedWorkflow()
        {
            var result = _runWorkflowHandler(@"NEP6_CodedWorkflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the GlobalHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"GlobalHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the EP2_Flowchart.xaml
        /// </summary>
        public void EP2_Flowchart(string argument1, string argument2, string argument3, string argument4, string argument5)
        {
            var result = _runWorkflowHandler(@"EP2_Flowchart.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}, {"argument3", argument3}, {"argument4", argument4}, {"argument5", argument5}}, default, default, default);
        }

        /// <summary>
        /// Invokes the EP1_Sequence.xaml
        /// </summary>
        public (int[] out_EP1_IntArray_Arg, bool inOut_EP1_Bool_Arg) EP1_Sequence(System.Data.DataTable in_EP1_DT_Arg, System.IO.Pipelines.Pipe[] argument3, string in_EP1_String_Arg, string in_JsonString, bool inOut_EP1_Bool_Arg)
        {
            var result = _runWorkflowHandler(@"EP1_Sequence.xaml", new Dictionary<string, object>{{"in_EP1_DT_Arg", in_EP1_DT_Arg}, {"argument3", argument3}, {"in_EP1_String_Arg", in_EP1_String_Arg}, {"in_JsonString", in_JsonString}, {"inOut_EP1_Bool_Arg", inOut_EP1_Bool_Arg}}, default, default, default);
            return ((int[])result["out_EP1_IntArray_Arg"], (bool)result["inOut_EP1_Bool_Arg"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public (System.Data.DataTable[][] argument5, Newtonsoft.Json.Linq.JObject argument4) Main(string argument1, int argument2, System.Data.DataTable argument3, Newtonsoft.Json.Linq.JObject argument4)
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}, {"argument3", argument3}, {"argument4", argument4}}, default, default, default);
            return ((System.Data.DataTable[][])result["argument5"], (Newtonsoft.Json.Linq.JObject)result["argument4"]);
        }

        /// <summary>
        /// Invokes the EP3_StateMachine.xaml
        /// </summary>
        public void EP3_StateMachine(string in_JsonString)
        {
            var result = _runWorkflowHandler(@"EP3_StateMachine.xaml", new Dictionary<string, object>{{"in_JsonString", in_JsonString}}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP4_StateMachine.xaml
        /// </summary>
        public void NEP4_StateMachine()
        {
            var result = _runWorkflowHandler(@"NEP4_StateMachine.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP1_Sequence.xaml
        /// </summary>
        public void NEP1_Sequence()
        {
            var result = _runWorkflowHandler(@"NEP1_Sequence.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP5_Workflow.xaml
        /// </summary>
        public void NEP5_Workflow()
        {
            var result = _runWorkflowHandler(@"NEP5_Workflow.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP3_Flowchart.xaml
        /// </summary>
        public void NEP3_Flowchart()
        {
            var result = _runWorkflowHandler(@"NEP3_Flowchart.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the EP4_Workflow.xaml
        /// </summary>
        public void EP4_Workflow()
        {
            var result = _runWorkflowHandler(@"EP4_Workflow.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}