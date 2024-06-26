using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Win_CS_Webservice
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Webservice_Pet_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.User Webservice_Pet_CustomActivity(string in_FirstName, string in_LastNAme, string in_Email, string in_Username, string in_Password)
        {
            var result = _runWorkflowHandler(@"Webservice_Pet_CustomActivity.xaml", new Dictionary<string, object>{{"in_FirstName", in_FirstName}, {"in_LastNAme", in_LastNAme}, {"in_Email", in_Email}, {"in_Username", in_Username}, {"in_Password", in_Password}}, default, default, default);
            return (SwaggerPetstore.User)result["out_User"];
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