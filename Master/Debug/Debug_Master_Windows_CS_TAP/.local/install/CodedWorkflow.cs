using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
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
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Debug_Master_Windows_CS_TAP
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Testing.API.ITestingService), typeof(UiPath.Core.Activities.API.ISystemService), typeof(UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }

        protected UiPath.Testing.API.ITestingService testing { get => serviceContainer.Resolve<UiPath.Testing.API.ITestingService>(); }

        protected UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService uiAutomation { get => serviceContainer.Resolve<UiPath.UIAutomationNext.API.Contracts.IUiAutomationAppService>(); }
    }
}

namespace Debug_Master_Windows_CS_TAP.ObjectRepository
{
    public static class Descriptors
    {
        public static class Calculator
        {
            public static _Implementation._Calculator.__Main_screen Main_screen { get; private set; } = new _Implementation._Calculator.__Main_screen();
        }
    }
}

namespace Debug_Master_Windows_CS_TAP._Implementation
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

    namespace _Calculator._Main_screen
    {
        public class __Digit___5 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Digit___5(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WbUlBSG6ZkqytFl2nCEITg/yRFezGFZy026Z4krXgHPwQ", DisplayName = "Digit - 5", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_screen
    {
        public class __Operator___Equals : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Operator___Equals(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WbUlBSG6ZkqytFl2nCEITg/9xhf_smNREOpx7ye9KaWJA", DisplayName = "Operator - Equals", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_screen
    {
        public class __Operator___Multiply : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Operator___Multiply(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WbUlBSG6ZkqytFl2nCEITg/n56eojIH1kyvX2ooVFIjdQ", DisplayName = "Operator - Multiply", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_screen
    {
        public class __Result : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Result(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WbUlBSG6ZkqytFl2nCEITg/KkL82lQcdEiv3I0qB3qSlw", DisplayName = "Result", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator
    {
        public class __Main_screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Main_screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "WbUlBSG6ZkqytFl2nCEITg/MDNYVGz6bkqt73CT9_7BJA", DisplayName = "Main screen", Screen = this};
                Digit___5 = new _Implementation._Calculator._Main_screen.__Digit___5(this, null);
                Operator___Equals = new _Implementation._Calculator._Main_screen.__Operator___Equals(this, null);
                Operator___Multiply = new _Implementation._Calculator._Main_screen.__Operator___Multiply(this, null);
                Result = new _Implementation._Calculator._Main_screen.__Result(this, null);
            }

            public _Implementation._Calculator._Main_screen.__Digit___5 Digit___5 { get; private set; }

            public _Implementation._Calculator._Main_screen.__Operator___Equals Operator___Equals { get; private set; }

            public _Implementation._Calculator._Main_screen.__Operator___Multiply Operator___Multiply { get; private set; }

            public _Implementation._Calculator._Main_screen.__Result Result { get; private set; }
        }
    }
}