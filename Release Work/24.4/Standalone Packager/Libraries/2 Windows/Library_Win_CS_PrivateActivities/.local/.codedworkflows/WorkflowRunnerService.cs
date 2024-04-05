using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;
using Library_Win_CS_PrivateActivities.ObjectRepository;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Library_Win_CS_PrivateActivities
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the UsePrivateXamls_Custom_Activity.xaml
        /// </summary>
        public string UsePrivateXamls_Custom_Activity(string in_Message)
        {
            var result = _runWorkflowHandler(@"UsePrivateXamls_Custom_Activity.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default);
            return (string)result["out_AssetValue"];
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Private/LogWarnMessage_Custom_Private.xaml
        /// </summary>
        public void LogWarnMessage_Custom_Private(string in_Message)
        {
            var result = _runWorkflowHandler(@"Private\LogWarnMessage_Custom_Private.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Private/GetAsset_Custom_Private.xaml
        /// </summary>
        public string GetAsset_Custom_Private()
        {
            var result = _runWorkflowHandler(@"Private\GetAsset_Custom_Private.xaml", new Dictionary<string, object>{}, default, default, default);
            return (string)result["out_AssetValue"];
        }
    }
}