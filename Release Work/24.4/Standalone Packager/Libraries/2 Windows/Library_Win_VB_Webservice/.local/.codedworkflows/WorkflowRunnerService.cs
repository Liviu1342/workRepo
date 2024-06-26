using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Library_Win_VB_Webservice
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Pet_CustomActivity.xaml
        /// </summary>
        public SwaggerPetstore.Pet Pet_CustomActivity(System.Nullable<long> in_PetID, string in_PetName)
        {
            var result = _runWorkflowHandler(@"Pet_CustomActivity.xaml", new Dictionary<string, object>{{"in_PetID", in_PetID}, {"in_PetName", in_PetName}}, default, default, default);
            return (SwaggerPetstore.Pet)result["out_PetResponse"];
        }

        /// <summary>
        /// Invokes the Coded/UseFotballTeam_Custom_Activity_Coded.cs
        /// </summary>
        public void UseFotballTeam_Custom_Activity_Coded()
        {
            var result = _runWorkflowHandler(@"Coded\UseFotballTeam_Custom_Activity_Coded.cs", new Dictionary<string, object>{}, default, default, default);
        }
    }
}