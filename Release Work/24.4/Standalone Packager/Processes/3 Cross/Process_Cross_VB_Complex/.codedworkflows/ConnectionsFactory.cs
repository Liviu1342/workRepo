using UiPath.CodedWorkflows;
using System;

namespace Process_Cross_VB_Complex
{
    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection My_Workspace_liviu_ponova_uipath_com { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_liviu_ponova_uipath_com = new UiPath.GSuite.Activities.Api.DriveConnection("db5e4961-010c-ed11-bd6e-00155da8c6f3", resolver);
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_ponova_liviu_gmail_com { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_travellingthroughart_gmail_com { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection All_Unattended_Robot_Types_ponova_liviu_gmail_com { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection test_ponova_liviu_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("bf0ebd32-010c-ed11-bd6e-00155da8c6f3", resolver);
            My_Workspace_travellingthroughart_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("0227bb7e-b83d-4fba-9821-368b9bae550d", resolver);
            All_Unattended_Robot_Types_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("e567808a-bc4d-4a79-84a8-f24e0070fc04", resolver);
            test_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("071d2a94-c528-40a3-94e9-b2b51f8b1cc2", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class ExcelFactory
    {
        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_Liviu_Ponova_uipath_com { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("3283541e-6eb4-46cb-91d7-807ee8606a1c", resolver);
        }
    }

    public class OneDriveFactory
    {
        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}