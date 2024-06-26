using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace GetInformationForCompany
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public string Main(string Account_Name)
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{{"Account_Name", Account_Name}}, default, default, default);
            return (string)result["resultMessage"];
        }

        /// <summary>
        /// Invokes the CallLLMGateway.cs
        /// </summary>
        public (System.String response, System.String error) CallLLMGateway(System.String accessToken, System.String resourceUrl, System.String organizationId, System.String tenantId, System.String systemMessage, System.String userMessage)
        {
            var result = _runWorkflowHandler(@"CallLLMGateway.cs", new Dictionary<string, object>{{"accessToken", accessToken}, {"resourceUrl", resourceUrl}, {"organizationId", organizationId}, {"tenantId", tenantId}, {"systemMessage", systemMessage}, {"userMessage", userMessage}}, default, default, default);
            return ((System.String)result["response"], (System.String)result["error"]);
        }

        /// <summary>
        /// Invokes the GetUserInfo.cs
        /// </summary>
        public (System.String accessToken, System.String resourceUrl, System.String tenantId, System.String organizationId) GetUserInfo()
        {
            var result = _runWorkflowHandler(@"GetUserInfo.cs", new Dictionary<string, object>{}, default, default, default);
            return ((System.String)result["accessToken"], (System.String)result["resourceUrl"], (System.String)result["tenantId"], (System.String)result["organizationId"]);
        }
    }
}