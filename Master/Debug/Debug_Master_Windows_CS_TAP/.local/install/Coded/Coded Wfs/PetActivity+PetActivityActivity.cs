using System;
using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using Debug_Master_Windows_CS_TAP.ObjectRepository;
using System.Collections.Generic;
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

namespace Debug_Master_Windows_CS_TAP.Coded.CodedWfs
{
    public class PetActivityActivity : System.Activities.Activity
    {
        public PetActivityActivity()
        {
            this.Implementation = () =>
            {
                return new PetActivityActivityChild()
                {};
            };
        }
    }

    internal class PetActivityActivityChild : CodeActivity
    {
        public PetActivityActivityChild()
        {
            DisplayName = "PetActivity";
        }

        protected override void Execute(CodeActivityContext context)
        {
            var codedWorkflow = new global::Debug_Master_Windows_CS_TAP.Coded.CodedWfs.PetActivity();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Coded\\Coded Wfs\\PetActivity.cs"});
                }
            }, () =>
            {
                codedWorkflow.Execute();
                return null;
            }, (exception, outArgs) =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.After(new AfterRunContext()
                    {RelativeFilePath = "Coded\\Coded Wfs\\PetActivity.cs", Exception = exception});
                }
            });
        }
    }
}