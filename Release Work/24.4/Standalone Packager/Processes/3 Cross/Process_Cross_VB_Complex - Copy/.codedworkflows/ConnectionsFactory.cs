using UiPath.CodedWorkflows;
using System;

namespace Process_Cross_VB_Complex
{
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