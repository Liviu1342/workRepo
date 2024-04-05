using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;
using System.Data;
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

namespace Library_Cross_CS_Webservice
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFootballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFootballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Webservice_User_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.User Webservice_User_CustomActivity(string in_FirstNAme, string in_LastName, string in_Username, string in_Password, string in_Email)
        {
            var result = _runWorkflowHandler(@"Webservice_User_CustomActivity.xaml", new Dictionary<string, object>{{"in_FirstNAme", in_FirstNAme}, {"in_LastName", in_LastName}, {"in_Username", in_Username}, {"in_Password", in_Password}, {"in_Email", in_Email}}, default, default, default);
            return (SwaggerPetstore.User)result["out_User"];
        }
    }
}