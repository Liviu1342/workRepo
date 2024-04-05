using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;
using Library_Win_CS_Entities.ObjectRepository;
using System.Data;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Mail.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Library_Win_CS_Entities
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the CatEntity_CustomActivity.xaml
        /// </summary>
        public Library_Win_CS_Entities.CatEntity CatEntity_CustomActivity(string in_CatName, string in_Abc)
        {
            var result = _runWorkflowHandler(@"CatEntity_CustomActivity.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}, {"in_Abc", in_Abc}}, default, default, default);
            return (Library_Win_CS_Entities.CatEntity)result["outputRecord"];
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