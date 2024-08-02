using UiPath.CodedWorkflows;
using System;

namespace Library_Win_VB_Complex
{
    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection My_Workspace_liviu_ponova_uipath_com { get; set; }

        public UiPath.GSuite.Activities.Api.DriveConnection test_liviu_ponova_uipath_com { get; set; }

        public UiPath.GSuite.Activities.Api.DriveConnection test_ponova_liviu_gmail_com { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_liviu_ponova_uipath_com = new UiPath.GSuite.Activities.Api.DriveConnection("fc7c19d6-6da0-ec11-a99b-e42aac668fcd", resolver);
            test_liviu_ponova_uipath_com = new UiPath.GSuite.Activities.Api.DriveConnection("a6575722-b2d8-4fee-b249-b1317161db35", resolver);
            test_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.DriveConnection("686ddd1a-8f41-493d-b731-b1271763dd22", resolver);
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_ponova_liviu_gmail_com { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection test_ponova_liviu_gmail_com { get; set; }

        public UiPath.GSuite.Activities.Api.GmailConnection test_travellingthroughart_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("17d677e4-6ae6-ec11-b656-e42aac668fcd", resolver);
            test_ponova_liviu_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("3311c5e4-3532-4f56-960f-c222a7171aff", resolver);
            test_travellingthroughart_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("0b1f6291-0374-4186-a76e-65a0b8dce537", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public UiPath.GSuite.Activities.Api.SheetsConnection My_Workspace_liviu_ponova_uipath_com { get; set; }

        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_liviu_ponova_uipath_com = new UiPath.GSuite.Activities.Api.SheetsConnection("952542ee-6da0-ec11-a99b-e42aac668fcd", resolver);
        }
    }

    public class ExcelFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection My_Workspace_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection test_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection My_Workspace_liviuponova_live_com { get; set; }

        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("6c7f2070-9d31-4c48-8be2-75a2929ce624", resolver);
            test_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("1af40a6a-78a2-4f6e-837c-8ea8cfb5ed83", resolver);
            My_Workspace_liviuponova_live_com = new UiPath.MicrosoftOffice365.Activities.Api.ExcelConnection("f6fbad08-8ae6-467e-8fe0-d8ce55699db9", resolver);
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_Personal_account { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection test_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection test_Personal_account { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("7ab8e158-a79f-ec11-a99b-e42aac668fcd", resolver);
            My_Workspace_Personal_account = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("0dbd2c18-2889-4a95-8361-723612849cad", resolver);
            test_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("2f0ccaae-8a8d-4c94-aff5-5f3663378bd9", resolver);
            test_Personal_account = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("b4e33468-5798-4d50-ba80-5b0a6588eeff", resolver);
        }
    }

    public class OneDriveFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection My_Workspace_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection test_Liviu_Ponova_uipath_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection My_Workspace_liviuponova_live_com { get; set; }

        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("6c7f2070-9d31-4c48-8be2-75a2929ce624", resolver);
            test_Liviu_Ponova_uipath_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("1af40a6a-78a2-4f6e-837c-8ea8cfb5ed83", resolver);
            My_Workspace_liviuponova_live_com = new UiPath.MicrosoftOffice365.Activities.Api.OneDriveConnection("f6fbad08-8ae6-467e-8fe0-d8ce55699db9", resolver);
        }
    }
}