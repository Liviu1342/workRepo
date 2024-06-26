using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using Connections_Win_VB_Library;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace Connections_Win_VB_Library
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/2nd_Invoker.xaml
        /// </summary>
        public (UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile, UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[] out_Jit_UserGroups, UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[] out_JIRA_Jit_Comments, string out_OpenAI_TopGeneratedText) _2nd_Invoker(string in_GitHub_Path)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\2nd_Invoker.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"], (UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[])result["out_Jit_UserGroups"], (UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[])result["out_JIRA_Jit_Comments"], (string)result["out_OpenAI_TopGeneratedText"]);
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeDifferentConnections.xaml
        /// </summary>
        public (string libraryOutArgument_CV, string libraryOutArgument_PV) _2SameTypeDifferentConnections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeDifferentConnections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["libraryOutArgument_CV"], (string)result["libraryOutArgument_PV"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/2nd Level Invoke - Single Connection Activity File.xaml
        /// </summary>
        public string _2nd_Level_Invoke___Single_Connection_Activity_File()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\2nd Level Invoke - Single Connection Activity File.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["out_DownloadFile"];
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeSameDisplayNameDiffConnections.xaml
        /// </summary>
        public (string DownloadFile_FirstOutArg, string DownloadFile_SecondOutArg) _2SameTypeSameDisplayNameDiffConnections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeSameDisplayNameDiffConnections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["DownloadFile_FirstOutArg"], (string)result["DownloadFile_SecondOutArg"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/2nd Level Invoke - Invoke Same File Multiple Times.xaml
        /// </summary>
        public void _2nd_Level_Invoke___Invoke_Same_File_Multiple_Times()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\2nd Level Invoke - Invoke Same File Multiple Times.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeSameConnection.xaml
        /// </summary>
        public (string libraryOutArgument_CV, string libraryOutArgument_PV) _2SameTypeSameConnection()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeSameConnection.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["libraryOutArgument_CV"], (string)result["libraryOutArgument_PV"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke_Private_Files.xaml
        /// </summary>
        public void Invoke_Private_Files()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke_Private_Files.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeSameDisplayNameSameConnection.xaml
        /// </summary>
        public (string DownloadFile_FirstOutArg, string DownloadFile_SecondOutArg) _2SameTypeSameDisplayNameSameConnection()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeSameDisplayNameSameConnection.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["DownloadFile_FirstOutArg"], (string)result["DownloadFile_SecondOutArg"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke_GMail_Enabled_Outlook_Disabled.xaml
        /// </summary>
        public void Invoke_GMail_Enabled_Outlook_Disabled()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke_GMail_Enabled_Outlook_Disabled.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Connections/GMail.xaml
        /// </summary>
        public void GMail()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\GMail.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke_2_Google_1_GitHub_3_DAP.xaml
        /// </summary>
        public (UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[] out_Jit_UserGroups, UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[] out_JIRA_DAP_Comments, string out_OpenAI_topGeneratedText, UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile) Invoke_2_Google_1_GitHub_3_DAP(string in_GitHub_Path)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke_2_Google_1_GitHub_3_DAP.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}}, default, default, default, GetAssemblyName());
            return ((UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[])result["out_Jit_UserGroups"], (UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[])result["out_JIRA_DAP_Comments"], (string)result["out_OpenAI_topGeneratedText"], (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"]);
        }

        /// <summary>
        /// Invokes the Connections/Slack activity.xaml
        /// </summary>
        public void Slack_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\Slack activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke_2_Google_1_GitHub + Private_DAP.xaml
        /// </summary>
        public (UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile, UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[] out_Jit_UserGroups, UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[] out_JIRA_Jit_Comments, string out_OpenAI_TopGeneratedText) Invoke_2_Google_1_GitHub___Private_DAP(string in_GitHub_Path)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke_2_Google_1_GitHub + Private_DAP.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"], (UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[])result["out_Jit_UserGroups"], (UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[])result["out_JIRA_Jit_Comments"], (string)result["out_OpenAI_TopGeneratedText"]);
        }

        /// <summary>
        /// Invokes the Connections/OneDrive activity.xaml
        /// </summary>
        public void OneDrive_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\OneDrive activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke Single Connection Activity File.xaml
        /// </summary>
        public string Invoke_Single_Connection_Activity_File()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke Single Connection Activity File.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["out_DownloadFile"];
        }

        /// <summary>
        /// Invokes the Integration activity.xaml
        /// </summary>
        public void Integration_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Integration activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/Flowchart - Invoke public and private workflows with connections.xaml
        /// </summary>
        public void Flowchart___Invoke_public_and_private_workflows_with_connections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\Flowchart - Invoke public and private workflows with connections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/2nd Level - Invoke Provate CopyFile GDrive.xaml
        /// </summary>
        public UiPath.GSuite.Drive.Models.GDriveRemoteItem _2nd_Level___Invoke_Provate_CopyFile_GDrive()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\2nd Level - Invoke Provate CopyFile GDrive.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GDrive_file"];
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke Same File Multiple Times.xaml
        /// </summary>
        public (UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile, UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder_2, UiPath.GSuite.Models.GmailMessage out_GMail_email_2, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile_2) Invoke_Same_File_Multiple_Times(string in_GitHub_Path, string in_GitHub_Path_2)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke Same File Multiple Times.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}, {"in_GitHub_Path_2", in_GitHub_Path_2}}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"], (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder_2"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email_2"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile_2"]);
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeSameConnection_1DifferentType.xaml
        /// </summary>
        public (string GSuite_DownloadFileCV_OutArg, string GSuite_DownloadFilePV_OutArg, string MSOffice_DownloadFile_OutArg) _2SameTypeSameConnection_1DifferentType()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeSameConnection_1DifferentType.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["GSuite_DownloadFileCV_OutArg"], (string)result["GSuite_DownloadFilePV_OutArg"], (string)result["MSOffice_DownloadFile_OutArg"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke Private CopyFile GDrive.xaml
        /// </summary>
        public UiPath.GSuite.Drive.Models.GDriveRemoteItem Invoke_Private_CopyFile_GDrive(string in_NewNameForFile)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke Private CopyFile GDrive.xaml", new Dictionary<string, object>{{"in_NewNameForFile", in_NewNameForFile}}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GDrive_file"];
        }

        /// <summary>
        /// Invokes the From Gabriela/2DiffTypes.xaml
        /// </summary>
        public (string GSuite_DownloadFile_OutArg, string MSOffice_DownloadFile_OutArg) _2DiffTypes()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2DiffTypes.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["GSuite_DownloadFile_OutArg"], (string)result["MSOffice_DownloadFile_OutArg"]);
        }

        /// <summary>
        /// Invokes the Invokers - Level 1/Invoke 1 Enabled GMail and 1 Disabled OneDrive.xaml
        /// </summary>
        public UiPath.GSuite.Models.GmailMessage Invoke_1_Enabled_GMail_and_1_Disabled_OneDrive()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 1\Invoke 1 Enabled GMail and 1 Disabled OneDrive.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"];
        }

        /// <summary>
        /// Invokes the Connections/Disabled/Outlook Disabled Gmail Enabled activity.xaml
        /// </summary>
        public UiPath.GSuite.Models.GmailMessage Outlook_Disabled_Gmail_Enabled_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\Disabled\Outlook Disabled Gmail Enabled activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"];
        }

        /// <summary>
        /// Invokes the Invoked Files/Private_CopyFile_GDrive.xaml
        /// </summary>
        public UiPath.GSuite.Drive.Models.GDriveRemoteItem Private_CopyFile_GDrive(string in_NewNameForFile)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked Files\Private_CopyFile_GDrive.xaml", new Dictionary<string, object>{{"in_NewNameForFile", in_NewNameForFile}}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GDrive_file"];
        }

        /// <summary>
        /// Invokes the Connections/Microsoft 365 activity.xaml
        /// </summary>
        public void Microsoft_365_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\Microsoft 365 activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invoked Files/Private - DAP_Connections.xaml
        /// </summary>
        public (string out_OpenAI_TopGeneratedText, UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[] out_JIRA_Jit_Comments, UiPath.IntegrationService.Activities.SWEntities.CB97BF74137_usergroups_List.Bundle.usergroups_List[] out_Jit_UserGroups) Private___DAP_Connections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked Files\Private - DAP_Connections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["out_OpenAI_TopGeneratedText"], (UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[])result["out_JIRA_Jit_Comments"], (UiPath.IntegrationService.Activities.SWEntities.CB97BF74137_usergroups_List.Bundle.usergroups_List[])result["out_Jit_UserGroups"]);
        }

        /// <summary>
        /// Invokes the Connections/Disabled/Disabled Gmail Connection activity.xaml
        /// </summary>
        public UiPath.GSuite.Models.GmailMessage Disabled_Gmail_Connection_activity()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\Disabled\Disabled Gmail Connection activity.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Models.GmailMessage)result["out_Gmail_Email"];
        }

        /// <summary>
        /// Invokes the Invoked Files/Private - 2_Google_SameConnection_1_GitHub.xaml
        /// </summary>
        public (UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile) Private___2_Google_SameConnection_1_GitHub(string in_GitHub_Path)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked Files\Private - 2_Google_SameConnection_1_GitHub.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"]);
        }

        /// <summary>
        /// Invokes the From Gabriela/2SameTypeSameDisplayNameSameConnectionInvoker.xaml
        /// </summary>
        public (string DownloadFile_FirstOutArg, string DownloadFile_SecondOutArg) _2SameTypeSameDisplayNameSameConnectionInvoker()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\2SameTypeSameDisplayNameSameConnectionInvoker.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["DownloadFile_FirstOutArg"], (string)result["DownloadFile_SecondOutArg"]);
        }

        /// <summary>
        /// Invokes the Invoked Files/DAP_Connections.xaml
        /// </summary>
        public (UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[] out_Jit_UserGroups, UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[] out_JIRA_DAP_Comments, string out_OpenAI_topGeneratedText) DAP_Connections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked Files\DAP_Connections.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((UiPath.IntegrationService.Activities.SWEntities.CC052707C93_usergroups_List.Bundle.usergroups_List[])result["out_Jit_UserGroups"], (UiPath.IntegrationService.Activities.SWEntities.C8F4F95C39B_issue_comment_List.Bundle.issue_comment_List[])result["out_JIRA_DAP_Comments"], (string)result["out_OpenAI_topGeneratedText"]);
        }

        /// <summary>
        /// Invokes the NoConnection.xaml
        /// </summary>
        public (string argument3, string argument4) NoConnection(string argument1, string argument2)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"NoConnection.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}}, default, default, default, GetAssemblyName());
            return ((string)result["argument3"], (string)result["argument4"]);
        }

        /// <summary>
        /// Invokes the Invoked Files/2_Google_SameConnection_1_GitHub.xaml
        /// </summary>
        public (UiPath.GSuite.Drive.Models.GDriveRemoteItem out_GoogleDrive_FileOrFilder, UiPath.GSuite.Models.GmailMessage out_GMail_email, UiPath.Platform.ResourceHandling.IResource out_GitHub_DownloadFile) _2_Google_SameConnection_1_GitHub(string in_GitHub_Path)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoked Files\2_Google_SameConnection_1_GitHub.xaml", new Dictionary<string, object>{{"in_GitHub_Path", in_GitHub_Path}}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Drive.Models.GDriveRemoteItem)result["out_GoogleDrive_FileOrFilder"], (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"], (UiPath.Platform.ResourceHandling.IResource)result["out_GitHub_DownloadFile"]);
        }

        /// <summary>
        /// Invokes the Assets.xaml
        /// </summary>
        public string Assets(string argument1, string argument2)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Assets.xaml", new Dictionary<string, object>{{"argument1", argument1}, {"argument2", argument2}}, default, default, default, GetAssemblyName());
            return (string)result["out_AssetValue"];
        }

        /// <summary>
        /// Invokes the From Gabriela/Second_Invoker.xaml
        /// </summary>
        public string Second_Invoker()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\Second_Invoker.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["DownloadFile_OutArg"];
        }

        /// <summary>
        /// Invokes the Connections/Microsoft 365 activity 2.xaml
        /// </summary>
        public void Microsoft_365_activity_2()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Connections\Microsoft 365 activity 2.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Invokers - Level 2/2nd Level - Invoke Enabled GMail Disabled OneDrive.xaml
        /// </summary>
        public UiPath.GSuite.Models.GmailMessage _2nd_Level___Invoke_Enabled_GMail_Disabled_OneDrive()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invokers - Level 2\2nd Level - Invoke Enabled GMail Disabled OneDrive.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (UiPath.GSuite.Models.GmailMessage)result["out_GMail_email"];
        }

        /// <summary>
        /// Invokes the From Gabriela/Invoker.xaml
        /// </summary>
        public string Invoker()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\Invoker.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["DownloadFile_OutArg"];
        }

        /// <summary>
        /// Invokes the Invoke_CodedWorkflow_with_Connection.xaml
        /// </summary>
        public void Invoke_CodedWorkflow_with_Connection()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoke_CodedWorkflow_with_Connection.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the From Gabriela/TypeWithMultipleProperties.xaml
        /// </summary>
        public string TypeWithMultipleProperties()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\TypeWithMultipleProperties.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["MoveFile_OutArg"];
        }

        /// <summary>
        /// Invokes the From Gabriela/Invoked.xaml
        /// </summary>
        public string Invoked()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\Invoked.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return (string)result["DownloadFile_OutArg"];
        }

        /// <summary>
        /// Invokes the Invoke_Xaml_with_Connections.cs
        /// </summary>
        public void Invoke_Xaml_with_Connections()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Invoke_Xaml_with_Connections.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Multiple connections/MultipleConnections activity 1.xaml
        /// </summary>
        public (UiPath.GSuite.Drive.Models.GDriveRemoteItem[] out_GSuite_FilesOrFolders, UiPath.GSuite.Models.GmailMessage out_GSuite_Email, UiPath.Slack.IntegrationService.Client.Users[] out_Slack_UsersList) MultipleConnections_activity_1()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Multiple connections\MultipleConnections activity 1.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((UiPath.GSuite.Drive.Models.GDriveRemoteItem[])result["out_GSuite_FilesOrFolders"], (UiPath.GSuite.Models.GmailMessage)result["out_GSuite_Email"], (UiPath.Slack.IntegrationService.Client.Users[])result["out_Slack_UsersList"]);
        }

        /// <summary>
        /// Invokes the From Gabriela/TypeWithMultiplePropertiesInvoker.xaml
        /// </summary>
        public void TypeWithMultiplePropertiesInvoker()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\TypeWithMultiplePropertiesInvoker.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the From Gabriela/GSuite_DownloadFile.xaml
        /// </summary>
        public (string CVOutArgument, string PVOutArgument) GSuite_DownloadFile()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"From Gabriela\GSuite_DownloadFile.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
            return ((string)result["CVOutArgument"], (string)result["PVOutArgument"]);
        }

        /// <summary>
        /// Invokes the Workflow.cs
        /// </summary>
        public void Workflow()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workflow.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}