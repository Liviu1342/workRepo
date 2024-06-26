using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Process_Cross_VB_Complex_FixCompilation;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace Process_Cross_VB_Complex_FixCompilation
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the EntryPoints/EP1_Webservice.xaml
        /// </summary>
        public SwaggerPetstore.Pet EP1_Webservice(System.Nullable<long> in_PetId, string in_PetName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"EntryPoints\EP1_Webservice.xaml", new Dictionary<string, object>{{"in_PetId", in_PetId}, {"in_PetName", in_PetName}}, default, default, default, GetAssemblyName());
            return (SwaggerPetstore.Pet)result["out_Pet"];
        }

        /// <summary>
        /// Invokes the ErrorHandling/GlobalHandler-Ignore.xaml
        /// </summary>
        public UiPath.Activities.Contracts.ErrorAction GlobalHandler_Ignore(UiPath.Activities.Contracts.ExceptionHandlerArgs errorInfo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"ErrorHandling\GlobalHandler-Ignore.xaml", new Dictionary<string, object>{{"errorInfo", errorInfo}}, default, default, default, GetAssemblyName());
            return (UiPath.Activities.Contracts.ErrorAction)result["result"];
        }

        /// <summary>
        /// Invokes the Tests/TestCase_Webservice.xaml
        /// </summary>
        public SwaggerPetstore.Pet TestCase_Webservice()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\TestCase_Webservice.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (SwaggerPetstore.Pet)result["out_Pet"];
        }

        /// <summary>
        /// Invokes the EntryPoints/EP2_Entity.xaml
        /// </summary>
        public Library_Cross_VB_Entities.CatEntity EP2_Entity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"EntryPoints\EP2_Entity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (Library_Cross_VB_Entities.CatEntity)result["cat"];
        }

        /// <summary>
        /// Invokes the Private/Private_Flowchart.xaml
        /// </summary>
        public void Private_Flowchart()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Private\Private_Flowchart.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Tests/TestCase_Entity.xaml
        /// </summary>
        public void TestCase_Entity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Tests\TestCase_Entity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Non_EntryPoints/NEP1.xaml
        /// </summary>
        public void NEP1()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Non_EntryPoints\NEP1.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Coded/UseFootballTeam_Coded_Custom_Activity.cs
        /// </summary>
        public void UseFootballTeam_Coded_Custom_Activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Coded\UseFootballTeam_Coded_Custom_Activity.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}