using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Process_Cross_VB_Complex
{
    public class EP_RootFolder_Coded_Workflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            Log("This is a coded workflow");
            
            RunWorkflow("EP_RootFolder.xaml");
            
            Log("Exit coded workflow!", LogLevel.Warn);
        }
    }
}