using System;
using System.Net.Http;
using System.Threading.Tasks;
using GetInformationForCompany;
using Newtonsoft.Json;
using UiPath.CodedWorkflows;


namespace UiPathCSVBuilder{
    public class LLMGateway : CodedWorkflow
    {
        [Workflow]
        public async Task<(string response, string error)> Execute(
            string accessToken, 
            string resourceUrl, 
            string organizationId, 
            string tenantId,
            string systemMessage,
            string userMessage)
        {
            System.Console.WriteLine(accessToken);
            System.Console.WriteLine(resourceUrl);
            System.Console.WriteLine(organizationId);
            System.Console.WriteLine(tenantId);

            var systemContent = systemMessage;
            var userContent = userMessage;
            
            var hostUrl = "https://staging.uipath.com";

            if (string.IsNullOrEmpty(resourceUrl))
            {
                var uri = new Uri(resourceUrl);
                hostUrl = $"{uri.Scheme}://{uri.Host}";
            }
            try {                
                string messageContent = await LLMGatewayHelper.SendOpenAIRequest(accessToken, hostUrl, organizationId, tenantId, userContent, systemContent);                
                return (response: messageContent, error: "");
            } catch(Exception ex) {
                return (response: "", error: ex.Message);
            }
        }
        
        private static class LLMGatewayHelper
        {
            public static async Task<string> SendOpenAIRequest(string accessToken, string hostUrl, string organizationId, string tenantId, string userContent, string systemContent)
            {
                // Create an HTTP client
                HttpClient client = new HttpClient();

                // Set the mandatory request headers
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                client.DefaultRequestHeaders.Add("X-UiPath-LlmGateway-RequestingProduct", "Autopilot");
                client.DefaultRequestHeaders.Add("X-UiPath-LlmGateway-RequestingFeature", "RagAgent");
                client.DefaultRequestHeaders.Add("X-UiPath-LlmGateway-TimeoutSeconds", "300");

                // Create the request body with userContent and systemContent
                var requestBody = new
                {
                    model = "gpt-4-1106-Preview",
                    messages = new[]
                    {
                        new { role = "system", content = systemContent },
                        new { role = "user", content = userContent }                        
                    },
                    stream = false
                };

                // Serialize the request body
                string jsonRequestBody = JsonConvert.SerializeObject(requestBody);

                // Create HttpContent with the correct headers
                HttpContent content = new StringContent(jsonRequestBody, System.Text.Encoding.UTF8, "application/json");

                // Construct the full URL from the provided resourceUrl and other components
                string endpoint = "/llmgateway_/openai/deployments/gpt-4/chat/completions";
                string apiVersion = "api-version=2023-03-15-preview";
                string fullUrl = $"{hostUrl}/{organizationId}/{tenantId}{endpoint}?{apiVersion}";

                // Send the HTTP request
                HttpResponseMessage responseMessage = await client.PostAsync(fullUrl, content);

                // Extract the 'content' from the response message
                var responseContent = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(responseContent);
                
                var responseJson = JsonConvert.DeserializeObject<dynamic>(responseContent);
                string messageContent = responseJson.choices[0].message.content;

                return messageContent;
            }
        }
    }
}
