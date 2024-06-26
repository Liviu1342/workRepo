using System;
using System.Threading.Tasks;
using GetInformationForCompany;
using UiPath.CodedWorkflows;
using UiPath.Robot.Activities.Api;

namespace UiPathSalesPlays
{
    public class GetUserInfo : CodedWorkflow
    {

        [Workflow]
        public (string accessToken, string resourceUrl, string tenantId, string organizationId) Execute()
        {
            var executorRuntime = serviceContainer.Resolve<IExecutorRuntime>();
			var accessToken = "";
			var resourceUrl = "";
			var tenantId = "";
            var organizationId = "";
            try
            {
                var task = Task.Run(async () => {
                    accessToken = await executorRuntime.AccessProvider.GetAccessToken("orchestrator", false);
                    resourceUrl = await executorRuntime.AccessProvider.GetResourceUrl("orchestrator");
                });
                task.Wait();

                tenantId = executorRuntime.RunningJobInformation.TenantKey;
                organizationId = executorRuntime.RunningJobInformation.OrganizationId;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"GetUserInfo.Handle exception: {ex.Message}");
                Console.WriteLine($"GetUserInfo.Handle stack: {ex.StackTrace}");
            }
			var output = (accessToken: accessToken, resourceUrl: resourceUrl, tenantId: tenantId, organizationId: organizationId);
			return output;
        }
    }
}
