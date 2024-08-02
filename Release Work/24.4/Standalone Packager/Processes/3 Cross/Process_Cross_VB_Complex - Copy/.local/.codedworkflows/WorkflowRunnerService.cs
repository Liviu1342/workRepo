using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.Activities.Contracts;

namespace Process_Cross_VB_Complex
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the EP_RootFolder_Entity_Flowchart.xaml
        /// </summary>
        public Library_Cross_VB_Entities.CatEntity EP_RootFolder_Entity_Flowchart(string in_CatName)
        {
            var result = _runWorkflowHandler(@"EP_RootFolder_Entity_Flowchart.xaml", new Dictionary<string, object>{{"in_CatName", in_CatName}}, default, default, default);
            return (Library_Cross_VB_Entities.CatEntity)result["cat"];
        }

        /// <summary>
        /// Invokes the EntryPoints/EP1_Webservice.xaml
        /// </summary>
        public SwaggerPetstore.Pet EP1_Webservice(System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _runWorkflowHandler(@"EntryPoints\EP1_Webservice.xaml", new Dictionary<string, object>{{"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default);
            return (SwaggerPetstore.Pet)result["out_Pet"];
        }

        /// <summary>
        /// Invokes the EntryPoints/EP2_Entity.xaml
        /// </summary>
        public Library_Cross_VB_Entities.CatEntity EP2_Entity()
        {
            var result = _runWorkflowHandler(@"EntryPoints\EP2_Entity.xaml", new Dictionary<string, object>{}, default, default, default);
            return (Library_Cross_VB_Entities.CatEntity)result["cat"];
        }

        /// <summary>
        /// Invokes the EP_RootFolder_Bindings.xaml
        /// </summary>
        public void EP_RootFolder_Bindings()
        {
            var result = _runWorkflowHandler(@"EP_RootFolder_Bindings.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the EP_RootFolder_OR.xaml
        /// </summary>
        public void EP_RootFolder_OR()
        {
            var result = _runWorkflowHandler(@"EP_RootFolder_OR.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the TestCase_Draft_RootFolder_Entity.xaml
        /// </summary>
        public void TestCase_Draft_RootFolder_Entity()
        {
            var result = _runWorkflowHandler(@"TestCase_Draft_RootFolder_Entity.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the ErrorHandling/GlobalHandler-Ignore.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Ignore(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"ErrorHandling\GlobalHandler-Ignore.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the GlobalHandler-Ignore_RootFolder.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Ignore_RootFolder(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _runWorkflowHandler(@"GlobalHandler-Ignore_RootFolder.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default);
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the EP_RootFolder_Webservice.xaml
        /// </summary>
        public SwaggerPetstore.Pet EP_RootFolder_Webservice()
        {
            var result = _runWorkflowHandler(@"EP_RootFolder_Webservice.xaml", new Dictionary<string, object>{}, default, default, default);
            return (SwaggerPetstore.Pet)result["out_pet"];
        }

        /// <summary>
        /// Invokes the Triggers/TimeTrigger.xaml
        /// </summary>
        public void TimeTrigger(string UiPathEventConnector, string UiPathEvent, string UiPathEventObjectType, string UiPathEventObjectId, string UiPathAdditionalEventData)
        {
            var result = _runWorkflowHandler(@"Triggers\TimeTrigger.xaml", new Dictionary<string, object>{{"UiPathEventConnector", UiPathEventConnector}, {"UiPathEvent", UiPathEvent}, {"UiPathEventObjectType", UiPathEventObjectType}, {"UiPathEventObjectId", UiPathEventObjectId}, {"UiPathAdditionalEventData", UiPathAdditionalEventData}}, default, default, default);
        }

        /// <summary>
        /// Invokes the TestCase_RootFolder_Webservice.xaml
        /// </summary>
        public void TestCase_RootFolder_Webservice()
        {
            var result = _runWorkflowHandler(@"TestCase_RootFolder_Webservice.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Private_Flowchart.xaml
        /// </summary>
        public void Private_Flowchart()
        {
            var result = _runWorkflowHandler(@"Private_Flowchart.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Private/Private_Flowchart.xaml
        /// </summary>
        public void Private_Private_Flowchart()
        {
            var result = _runWorkflowHandler(@"Private\Private_Flowchart.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Non_EntryPoints/NEP1.xaml
        /// </summary>
        public void NEP1()
        {
            var result = _runWorkflowHandler(@"Non_EntryPoints\NEP1.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the NEP_RootFolder.xaml
        /// </summary>
        public void NEP_RootFolder()
        {
            var result = _runWorkflowHandler(@"NEP_RootFolder.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the EP_RootFolder.xaml
        /// </summary>
        public void EP_RootFolder()
        {
            var result = _runWorkflowHandler(@"EP_RootFolder.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the EP_RootFolder_Coded_Workflow.cs
        /// </summary>
        public void EP_RootFolder_Coded_Workflow()
        {
            var result = _runWorkflowHandler(@"EP_RootFolder_Coded_Workflow.cs", new Dictionary<string, object>{}, default, default, default);
        }
    }
}