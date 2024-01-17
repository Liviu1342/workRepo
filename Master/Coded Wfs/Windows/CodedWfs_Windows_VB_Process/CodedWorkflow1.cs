using CodedWfs_Windows_VB_Process.ObjectRepository;
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

namespace CodedWfs_Windows_VB_Process
{
    public class CodedWorkflow1 : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
            // To start using services, use IntelliSense (CTRL + Space) to discover the available services:
            // e.g. system.GetAsset(...)

            // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
            // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);
            
            Log("Starting Coded Workflow");
            
            var test = 123;
            var stringTest = "1234";
            
            var argumentsDictionary = new Dictionary<String,Object>();
            argumentsDictionary.Add("in_Message", stringTest + " " + test.ToString());
            
            RunWorkflow("SequenceInvokedInCoded.xaml", argumentsDictionary, null, true);
            
            Log("Ending Coded Workflow");
        }
    }
}