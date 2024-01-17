using System.Activities;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Utils;
using Cross_VB_CodedWfs_Library_Master.SourceFiles.Pet;
using Cross_VB_CodedWfs_Library_Master.SourceFiles.Pet.Pets;
using Cross_VB_CodedWfs_Library_Master.Utils;
using System;
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

namespace Cross_VB_CodedWfs_Library_Master.CodedWfs
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
            var codedWorkflow = new global::Cross_VB_CodedWfs_Library_Master.CodedWfs.PetActivity();
            CodedWorkflowHelper.Initialize(codedWorkflow, context);
            CodedWorkflowHelper.RunWithExceptionHandling(() =>
            {
                if (codedWorkflow is IBeforeAfterRun codedWorkflowWithBeforeAfter)
                {
                    codedWorkflowWithBeforeAfter.Before(new BeforeRunContext()
                    {RelativeFilePath = "Coded Wfs\\PetActivity.cs"});
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
                    {RelativeFilePath = "Coded Wfs\\PetActivity.cs", Exception = exception});
                }
            });
        }
    }
}