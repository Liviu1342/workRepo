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

namespace ArgumentProperties_Process_Win_VB.EntryPoints
{
    public class EP5_CodedWorkflow : CodedWorkflow
    {
        [Workflow]
        public void Execute(string arg1)
        {
            Log(arg1);
        }
        
        public void Execute()
        {
            Log("this method does not use an argument");
        }
    }
}