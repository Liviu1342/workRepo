using System;
using System.Collections.Generic;
using System.Data;
using L_VB_Windows_testSuite2310._5.ObjectRepository;
using UiPath.CodedWorkflows;
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

namespace L_VB_Windows_testSuite2310._5
{
    public class TestCase : CodedWorkflow
    {
        [TestCase]
        public void Execute(System.Collections.Generic.IDictionary<System.String, System.Object> dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2)
        {

            dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 = dataQueue23_4_codedWf0019a6a6b6604971b05201fa839493c2 ?? System.Text.Json.JsonSerializer.Deserialize<IDictionary<System.String, System.Object>>(@"{""Address"":""Bucharest"",""FirstName"":""Viola"",""LastName"":""Verduzco"",""Date"":""2022-08-05T14:10:29.9585393"",""Number"":6.57595125660994E+18,""SomeText"":""nyttiphwbmvmmrodtmltrl""}", new System.Text.Json.JsonSerializerOptions());
            // Arrange

            Log("Test run started for TestCase.");
          

            // Act
            // For accessing UI Elements from Object Repository, you can use the Descriptors class e.g:
            // var screen = uiAutomation.Open(Descriptors.MyApp.FirstScreen);
            // screen.Click(Descriptors.MyApp.FirstScreen.SettingsButton);

            // Assert
            // To start using activities, use IntelliSense (CTRL + Space) to discover the available services, e.g. testing.VerifyExpression(...).
        }
    }
}