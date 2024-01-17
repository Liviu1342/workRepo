using Connections_Win_VB_Library.ObjectRepository;
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
using UiPath.Slack.IntegrationService.Activities;
using System.Threading.Tasks;
using UiPath.Activities.Contracts;

namespace Connections_Win_VB_Library
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Connections/Disabled/Outlook Disabled Gmail Enabled activity.xaml
        /// </summary>
        public void Outlook_Disabled_Gmail_Enabled_activity()
        {
            var result = _runWorkflowHandler(@"Connections\Disabled\Outlook Disabled Gmail Enabled activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/Microsoft 365 activity 2.xaml
        /// </summary>
        public void Microsoft_365_activity_2()
        {
            var result = _runWorkflowHandler(@"Connections\Microsoft 365 activity 2.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Multiple connections/MultipleConnections activity 1.xaml
        /// </summary>
        public void MultipleConnections_activity_1()
        {
            var result = _runWorkflowHandler(@"Multiple connections\MultipleConnections activity 1.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/Slack activity.xaml
        /// </summary>
        public void Slack_activity()
        {
            var result = _runWorkflowHandler(@"Connections\Slack activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
        public void Workflow()
        {
            var result = _runWorkflowHandler(@"Workflow.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/Microsoft 365 activity.xaml
        /// </summary>
        public void Microsoft_365_activity()
        {
            var result = _runWorkflowHandler(@"Connections\Microsoft 365 activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/OneDrive activity.xaml
        /// </summary>
        public void OneDrive_activity()
        {
            var result = _runWorkflowHandler(@"Connections\OneDrive activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Assets.xaml
        /// </summary>
        public string Assets(string argument1, string argument2)
        {
            var result = _runWorkflowHandler(@"Assets.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}}, default, default, default);
            return (string)result["out_AssetValue"];
        }

        /// <summary>
        /// Invokes the NoConnection.xaml
        /// </summary>
        public (string argument3, string argument4) NoConnection(string argument1, string argument2)
        {
            var result = _runWorkflowHandler(@"NoConnection.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}}, default, default, default);
            return ((string)result["argument3"], (string)result["argument4"]);
        }

        /// <summary>
        /// Invokes the Integration activity.xaml
        /// </summary>
        public void Integration_activity()
        {
            var result = _runWorkflowHandler(@"Integration activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/Disabled/Disabled Gmail Connection activity.xaml
        /// </summary>
        public void Disabled_Gmail_Connection_activity()
        {
            var result = _runWorkflowHandler(@"Connections\Disabled\Disabled Gmail Connection activity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Connections/GMail.xaml
        /// </summary>
        public void GMail()
        {
            var result = _runWorkflowHandler(@"Connections\GMail.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}