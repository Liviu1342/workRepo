using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Cross_CS_PrivateActivities
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
        public int GetAsset_Custom_Private()
        {
            var result = _runWorkflowHandler(@"Private Activities\GetAsset_Custom_Private.xaml", new Dictionary<string, object>{}, default, default, default);
            return (int)result["out_AssetValue"];
        }

        /// <summary>
        /// Invokes the UsesPrivateXamls_Custom_Activity.xaml
        /// </summary>
        public void UsesPrivateXamls_Custom_Activity(string in_Message)
        {
            var result = _runWorkflowHandler(@"UsesPrivateXamls_Custom_Activity.xaml", new Dictionary<string, object>{{"in_Message", in_Message}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Private Activities/LogWarnMessage_Custom_Private.xaml
        /// </summary>
        public void LogWarnMessage_Custom_Private(string in_MEssage)
        {
            var result = _runWorkflowHandler(@"Private Activities\LogWarnMessage_Custom_Private.xaml", new Dictionary<string, object>{{"in_MEssage", in_MEssage}}, default, default, default);
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }
    }
}