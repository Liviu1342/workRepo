using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.MicrosoftOffice365.Activities.Api;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace L_VB_Windows_testSuite2310._5
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService), typeof(UiPath.Testing.API.ITestingService)};
        }

        protected UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService office365 { get => serviceContainer.Resolve<UiPath.MicrosoftOffice365.Activities.Api.IOffice365ConnectionsService>(); }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace L_VB_Windows_testSuite2310._5.ObjectRepository
{
    public static class Descriptors
    {
        public static class FFAmazonApp
        {
            public static _Implementation._FFAmazonApp.__FFAmazonScreen FFAmazonScreen { get; private set; } = new _Implementation._FFAmazonApp.__FFAmazonScreen();
        }
    }
}

namespace L_VB_Windows_testSuite2310._5._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _FFAmazonApp._FFAmazonScreen
    {
        public class __Amazon_Basics : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Amazon_Basics(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PpyU3ePC4EmtS8oC2G9DpA/zJg6noNXkkaBCcltaU80QQ", DisplayName = "Amazon Basics", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _FFAmazonApp._FFAmazonScreen
    {
        public class __Best_Sellers : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Best_Sellers(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PpyU3ePC4EmtS8oC2G9DpA/WDBQV3bgYEipQFF4v_e7Lg", DisplayName = "Best Sellers", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _FFAmazonApp._FFAmazonScreen
    {
        public class __New_Releases : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Releases(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "PpyU3ePC4EmtS8oC2G9DpA/1eNBeEQbHUa9PgJpxRW2rw", DisplayName = "New Releases", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _FFAmazonApp
    {
        public class __FFAmazonScreen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __FFAmazonScreen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "PpyU3ePC4EmtS8oC2G9DpA/YoMjNyFSMk6l02PRZABnyw", DisplayName = "FFAmazonScreen", Screen = this};
                Amazon_Basics = new _Implementation._FFAmazonApp._FFAmazonScreen.__Amazon_Basics(this, null);
                Best_Sellers = new _Implementation._FFAmazonApp._FFAmazonScreen.__Best_Sellers(this, null);
                New_Releases = new _Implementation._FFAmazonApp._FFAmazonScreen.__New_Releases(this, null);
            }

            public _Implementation._FFAmazonApp._FFAmazonScreen.__Amazon_Basics Amazon_Basics { get; private set; }

            public _Implementation._FFAmazonApp._FFAmazonScreen.__Best_Sellers Best_Sellers { get; private set; }

            public _Implementation._FFAmazonApp._FFAmazonScreen.__New_Releases New_Releases { get; private set; }
        }
    }
}