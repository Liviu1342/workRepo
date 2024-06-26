using Connections_Win_VB_Library.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.GSuite.Activities.Api;
using UiPath.Mail.Activities.Api;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Connections_Win_VB_Library
{
    public class Invoke_Xaml_with_Connections : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            Log("test");
            
            RunWorkflow("Invoked Files\\2_Google_SameConnection_1_GitHub.xaml");
        }
    }
}