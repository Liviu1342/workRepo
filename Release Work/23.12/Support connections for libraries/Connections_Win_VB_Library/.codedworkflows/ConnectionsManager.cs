using UiPath.CodedWorkflows;
using System;

namespace Connections_Win_VB_Library
{
    public class ConnectionsManager
    {
        public ExcelFactory Excel { get; set; }

        public O365MailFactory O365Mail { get; set; }

        public OneDriveFactory OneDrive { get; set; }

        public DriveFactory Drive { get; set; }

        public GmailFactory Gmail { get; set; }

        public GoogleSheetsFactory GoogleSheets { get; set; }

        public ConnectionsManager(ICodedWorkflowsServiceContainer resolver)
        {
            Excel = new ExcelFactory(resolver);
            O365Mail = new O365MailFactory(resolver);
            OneDrive = new OneDriveFactory(resolver);
            Drive = new DriveFactory(resolver);
            Gmail = new GmailFactory(resolver);
            GoogleSheets = new GoogleSheetsFactory(resolver);
        }
    }
}