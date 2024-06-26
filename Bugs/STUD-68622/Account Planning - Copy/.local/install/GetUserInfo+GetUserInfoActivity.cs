using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using System.Runtime;

namespace GetInformationForCompany
{
    public class GetUserInfoActivity : System.Activities.Activity
    {
        public OutArgument<System.String> accessToken { get; set; }

        public OutArgument<System.String> resourceUrl { get; set; }

        public OutArgument<System.String> tenantId { get; set; }

        public OutArgument<System.String> organizationId { get; set; }

        public GetUserInfoActivity()
        {
            this.Implementation = () =>
            {
                return new GetUserInfoActivityChild()
                {accessToken = (this.accessToken == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "accessToken") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.accessToken, "accessToken")), resourceUrl = (this.resourceUrl == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "resourceUrl") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.resourceUrl, "resourceUrl")), tenantId = (this.tenantId == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "tenantId") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.tenantId, "tenantId")), organizationId = (this.organizationId == null ? (OutArgument<System.String>)Argument.CreateReference((Argument)new OutArgument<System.String>(), "organizationId") : (OutArgument<System.String>)Argument.CreateReference((Argument)this.organizationId, "organizationId")), };
            };
        }
    }

    internal class GetUserInfoActivityChild : UiPath.CodedWorkflows.AsyncTaskCodedWorkflowActivity
    {
        public OutArgument<System.String> accessToken { get; set; }

        public OutArgument<System.String> resourceUrl { get; set; }

        public OutArgument<System.String> tenantId { get; set; }

        public OutArgument<System.String> organizationId { get; set; }

        public System.Collections.Generic.IDictionary<string, object> newResult { get; set; }

        public GetUserInfoActivityChild()
        {
            DisplayName = "GetUserInfo";
        }

        protected override async System.Threading.Tasks.Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, System.Threading.CancellationToken cancellationToken)
        {
            var codedWorkflow = new global::UiPathSalesPlays.GetUserInfo();
            CodedWorkflowHelper.Initialize(codedWorkflow, new UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatureChecker(new System.Collections.Generic.List<string>()
            {UiPath.CodedWorkflows.Utils.CodedWorkflowsFeatures.AsyncEntrypoints}), context);
            var result = await System.Threading.Tasks.Task.Run(() => CodedWorkflowHelper.RunWithExceptionHandlingAsync(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "GetUserInfo.cs"});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }, () =>
            {
                ControlledExecution.Run(() =>
                {
                    {
                        var result = codedWorkflow.Execute();
                        newResult = new System.Collections.Generic.Dictionary<string, object>{{"accessToken", result.accessToken}, {"resourceUrl", result.resourceUrl}, {"tenantId", result.tenantId}, {"organizationId", result.organizationId}, };
                    }
                }, cancellationToken);
                return System.Threading.Tasks.Task.FromResult(newResult);
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "GetUserInfo.cs", Exception = exception});
                }

                return System.Threading.Tasks.Task.CompletedTask;
            }), cancellationToken);
            return endContext =>
            {
                accessToken.Set(endContext, (System.String)result["accessToken"]);
                resourceUrl.Set(endContext, (System.String)result["resourceUrl"]);
                tenantId.Set(endContext, (System.String)result["tenantId"]);
                organizationId.Set(endContext, (System.String)result["organizationId"]);
            };
        }
    }
}