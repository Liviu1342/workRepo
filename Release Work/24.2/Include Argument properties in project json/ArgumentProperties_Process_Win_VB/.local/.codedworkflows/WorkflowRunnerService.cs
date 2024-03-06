using ArgumentProperties_Process_Win_VB.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
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

namespace ArgumentProperties_Process_Win_VB
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP6_CodedWorkflow.cs
        /// </summary>
        public void NEP6_CodedWorkflow()
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP6_CodedWorkflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Entry Points/EP5_CodedWorkflow.cs
        /// </summary>
        public void EP5_CodedWorkflow()
        {
            var result = _runWorkflowHandler(@"Entry Points\EP5_CodedWorkflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Entry Points/EP2_Flowchart.xaml
        /// </summary>
        public (string[] out_EP2_StringArray_Arg, System.Collections.Generic.Dictionary<string, ExcelNumberFormat.NumberFormat> inOut_EP2_Dictionary_Arg) EP2_Flowchart(string in_EP2_String_Arg, int in_EP2_Int_Arg, bool in_EP2_Bool_Arg, System.Data.DataTable in_EP2_DataTable_Arg, System.Collections.Generic.List<System.Data.DataTable> in_EP2_ListOfComplexType_Arg, System.Collections.Generic.Dictionary<string, ExcelNumberFormat.NumberFormat> inOut_EP2_Dictionary_Arg)
        {
            var result = _runWorkflowHandler(@"Entry Points\EP2_Flowchart.xaml", new Dictionary<string, object>{{"in_EP2_String_Arg", in_EP2_String_Arg}, {"in_EP2_Int_Arg", in_EP2_Int_Arg}, {"in_EP2_Bool_Arg", in_EP2_Bool_Arg}, {"in_EP2_DataTable_Arg", in_EP2_DataTable_Arg}, {"in_EP2_ListOfComplexType_Arg", in_EP2_ListOfComplexType_Arg}, {"inOut_EP2_Dictionary_Arg", inOut_EP2_Dictionary_Arg}}, default, default, default);
            return ((string[])result["out_EP2_StringArray_Arg"], (System.Collections.Generic.Dictionary<string, ExcelNumberFormat.NumberFormat>)result["inOut_EP2_Dictionary_Arg"]);
        }

        /// <summary>
        /// Invokes the Entry Points/EP3_StateMachine.xaml
        /// </summary>
        public (int[] out_EP3_Int_Arg, System.Collections.Generic.List<ClosedXML.Excel.IXLColumn> inOut_EP3_ListOfComplexType) EP3_StateMachine(string in_EP3_Sring_Arg, System.Data.DataTable in_EP3_DataTable_Arg, System.Collections.Generic.Dictionary<string, System.Data.DataTable[]> in_EP3_Dictionary_Arg, System.Collections.Generic.List<ClosedXML.Excel.IXLColumn> inOut_EP3_ListOfComplexType)
        {
            var result = _runWorkflowHandler(@"Entry Points\EP3_StateMachine.xaml", new Dictionary<string, object>{{"in_EP3_Sring_Arg", in_EP3_Sring_Arg}, {"in_EP3_DataTable_Arg", in_EP3_DataTable_Arg}, {"in_EP3_Dictionary_Arg", in_EP3_Dictionary_Arg}, {"inOut_EP3_ListOfComplexType", inOut_EP3_ListOfComplexType}}, default, default, default);
            return ((int[])result["out_EP3_Int_Arg"], (System.Collections.Generic.List<ClosedXML.Excel.IXLColumn>)result["inOut_EP3_ListOfComplexType"]);
        }

        /// <summary>
        /// Invokes the Entry Points/EP4_Workflow.xaml
        /// </summary>
        public (System.Data.DataTable out_DataTable_Arg, string[] inOut_EP4_StringArray_Arg) EP4_Workflow(bool in_EP4_Bool_Arg, System.Collections.Generic.Dictionary<string, System.Data.DataTable[]> in_EP4_Dictionary_Arg, string[] inOut_EP4_StringArray_Arg)
        {
            var result = _runWorkflowHandler(@"Entry Points\EP4_Workflow.xaml", new Dictionary<string, object>{{"in_EP4_Bool_Arg", in_EP4_Bool_Arg}, {"in_EP4_Dictionary_Arg", in_EP4_Dictionary_Arg}, {"inOut_EP4_StringArray_Arg", inOut_EP4_StringArray_Arg}}, default, default, default);
            return ((System.Data.DataTable)result["out_DataTable_Arg"], (string[])result["inOut_EP4_StringArray_Arg"]);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public (int[] out_Main_IntArray_Arg, string[] inOut_Main_StringArray_Arg) Main(string in_Main_String_Arg, int in_Main_Int_Arg, bool in_Main_Bool_Arg, System.Collections.Generic.List<ExcelNumberFormat.NumberFormat> in_Main_ListOfComplexType_Arg, System.Data.DataTable in_Main_DataTable_Arg, string[] inOut_Main_StringArray_Arg)
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{{"in_Main_String_Arg", in_Main_String_Arg}, {"in_Main_Int_Arg", in_Main_Int_Arg}, {"in_Main_Bool_Arg", in_Main_Bool_Arg}, {"in_Main_ListOfComplexType_Arg", in_Main_ListOfComplexType_Arg}, {"in_Main_DataTable_Arg", in_Main_DataTable_Arg}, {"inOut_Main_StringArray_Arg", inOut_Main_StringArray_Arg}}, default, default, default);
            return ((int[])result["out_Main_IntArray_Arg"], (string[])result["inOut_Main_StringArray_Arg"]);
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP5_Workflow.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<Azure.HttpRange, Google.Apis.ETagAction> out_NEP5_Dictionary, string[] inOut_NEP5_StringArray) NEP5_Workflow(string in_NEP5_String, int in_NEP5_Int, bool in_NEP5_Bool, System.Data.DataTable in_NEP5_DataTable, System.Collections.Generic.List<CsvHelper.RecordBuilder> in_NEP5_ListOfComplexType, string[] inOut_NEP5_StringArray)
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP5_Workflow.xaml", new Dictionary<string, object>{{"in_NEP5_String", in_NEP5_String}, {"in_NEP5_Int", in_NEP5_Int}, {"in_NEP5_Bool", in_NEP5_Bool}, {"in_NEP5_DataTable", in_NEP5_DataTable}, {"in_NEP5_ListOfComplexType", in_NEP5_ListOfComplexType}, {"inOut_NEP5_StringArray", inOut_NEP5_StringArray}}, default, default, default);
            return ((System.Collections.Generic.Dictionary<Azure.HttpRange, Google.Apis.ETagAction>)result["out_NEP5_Dictionary"], (string[])result["inOut_NEP5_StringArray"]);
        }

        /// <summary>
        /// Invokes the Entry Points/EP1_Sequence.xaml
        /// </summary>
        public (System.Collections.Generic.Dictionary<Azure.HttpRange, Google.Apis.ETagAction> out_EP1_Dictionary, string[] inOut_EP1_StringArray) EP1_Sequence(string in_EP1_String, int in_EP1_Int, bool in_EP1_Bool, System.Data.DataTable in_EP1_DataTable, System.Collections.Generic.List<CsvHelper.RecordBuilder> in_EP1_ListOfComplexType, string[] inOut_EP1_StringArray)
        {
            var result = _runWorkflowHandler(@"Entry Points\EP1_Sequence.xaml", new Dictionary<string, object>{{"in_EP1_String", in_EP1_String}, {"in_EP1_Int", in_EP1_Int}, {"in_EP1_Bool", in_EP1_Bool}, {"in_EP1_DataTable", in_EP1_DataTable}, {"in_EP1_ListOfComplexType", in_EP1_ListOfComplexType}, {"inOut_EP1_StringArray", inOut_EP1_StringArray}}, default, default, default);
            return ((System.Collections.Generic.Dictionary<Azure.HttpRange, Google.Apis.ETagAction>)result["out_EP1_Dictionary"], (string[])result["inOut_EP1_StringArray"]);
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP9_GlobalHandler.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction NEP9_GlobalHandler(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP9_GlobalHandler.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP1_Sequence.xaml
        /// </summary>
        public void NEP1_Sequence(string argument1, string argument2)
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP1_Sequence.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP3_StateMachine.xaml
        /// </summary>
        public void NEP3_StateMachine()
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP3_StateMachine.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Non Entry Points/NEP2_Flowchart.xaml
        /// </summary>
        public void NEP2_Flowchart()
        {
            var result = _runWorkflowHandler(@"Non Entry Points\NEP2_Flowchart.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}