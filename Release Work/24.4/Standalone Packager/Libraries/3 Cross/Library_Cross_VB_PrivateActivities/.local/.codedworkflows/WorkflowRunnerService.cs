using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Cross_VB_PrivateActivities
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Private Activities/GetAsset_Custom_Private.xaml
        /// </summary>
        public string GetAsset_Custom_Private()
        {
            var result = _runWorkflowHandler(@"Private Activities\GetAsset_Custom_Private.xaml", new Dictionary<string, object>{}, default, default, default);
            return (string)result["out_AssetValue"];
        }

        /// <summary>
        /// Invokes the Private Activities/LogWarnMessage_Custom_Private.xaml
        /// </summary>
        public void LogWarnMessage_Custom_Private(string in_Message)
        {
            var result = _runWorkflowHandler(@"Private Activities\LogWarnMessage_Custom_Private.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default);
        }

        /// <summary>
        /// Invokes the UsesPrivateXamls_Custom_Activity.xaml
        /// </summary>
        public string UsesPrivateXamls_Custom_Activity(string in_Message)
        {
            var result = _runWorkflowHandler(@"UsesPrivateXamls_Custom_Activity.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default);
            return (string)result["out_AssetValue"];
        }
    }
}