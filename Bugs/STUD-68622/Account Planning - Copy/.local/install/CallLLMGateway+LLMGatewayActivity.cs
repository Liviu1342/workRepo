using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace GetInformationForCompany
{
    public class LLMGatewayActivity : System.Activities.Activity
    {
        public InArgument<System.String> accessToken { get; set; }

        public InArgument<System.String> resourceUrl { get; set; }

        public InArgument<System.String> organizationId { get; set; }

        public InArgument<System.String> tenantId { get; set; }

        public InArgument<System.String> systemMessage { get; set; }

        public InArgument<System.String> userMessage { get; set; }

        public OutArgument<System.String> response { get; set; }

        public OutArgument<System.String> error { get; set; }

        public LLMGatewayActivity()
        {
            this.Implementation = () =>
            {
                return new LLMGatewayActivityChild()
                {accessToken = (this.accessToken == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "accessToken") : (InArgument<System.String>)Argument.CreateReference((Argument)this.accessToken, "accessToken")), resourceUrl = (this.resourceUrl == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "resourceUrl") : (InArgument<System.String>)Argument.CreateReference((Argument)this.resourceUrl, "resourceUrl")), organizationId = (this.organizationId == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "organizationId") : (InArgument<System.String>)Argument.CreateReference((Argument)this.organizationId, "organizationId")), tenantId = (this.tenantId == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "tenantId") : (InArgument<System.String>)Argument.CreateReference((Argument)this.tenantId, "tenantId")), systemMessage = (this.systemMessage == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "systemMessage") : (InArgument<System.String>)Argument.CreateReference((Argument)this.systemMessage, "systemMessage")), userMessage = (this.userMessage == null ? (InArgument<System.String>)Argument.CreateReference((Argument)new InArgument<System.String>(), "userMessage") : (InArgument<System.String>)Argument.CreateReference((Argument)this.userMessage, "userMessage")), response = (this.response == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "response") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.response, "response")), error = (this.error == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "error") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.error, "error")), };
            };
        }
    }

    internal class LLMGatewayActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public InArgument<System.String> accessToken { get; set; }

        public InArgument<System.String> resourceUrl { get; set; }

        public InArgument<System.String> organizationId { get; set; }

        public InArgument<System.String> tenantId { get; set; }

        public InArgument<System.String> systemMessage { get; set; }

        public InArgument<System.String> userMessage { get; set; }

        public OutArgument<System.String> response { get; set; }

        public OutArgument<System.String> error { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public LLMGatewayActivityChild()
        {
            DisplayName = "LLMGateway";
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::UiPathCSVBuilder.LLMGateway();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            var result = await codedWorkflow.Execute(accessToken.Get(context), resourceUrl.Get(context), organizationId.Get(context), tenantId.Get(context), systemMessage.Get(context), userMessage.Get(context));
            newResult = new System.Collections.Generic.Dictionary<string, object>{{"response", result.response}, {"error", result.error}, };
            return endContext =>
            {
                response.Set(endContext, (System.String)newResult["response"]);
                error.Set(endContext, (System.String)newResult["error"]);
            };
        }
    }
}