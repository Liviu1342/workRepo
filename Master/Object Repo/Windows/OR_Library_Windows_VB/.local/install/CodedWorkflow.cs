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

namespace OR_Library_Windows_VB
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

namespace OR_Library_Windows_VB.ObjectRepository
{
    public static class Descriptors
    {
        public static class Calculator
        {
            public static OR_Library_Windows_VB._Implementation._Calculator.__Main_Screen Main_Screen { get; private set; } = new OR_Library_Windows_VB._Implementation._Calculator.__Main_Screen();
        }
    }
}

namespace OR_Library_Windows_VB._Implementation
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

    namespace _Calculator._Main_Screen
    {
        public class __digit_5 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __digit_5(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/85THQ_sGRU-Fi-cEwVRCfw", DisplayName = "digit 5", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_Screen
    {
        public class __digit_7 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __digit_7(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/CXEYnoyvtE-5yHjEf43cFg", DisplayName = "digit 7", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_Screen
    {
        public class __operator_equal : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __operator_equal(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/xSuZJ3BHhUqg6e9yx0bvHw", DisplayName = "operator equal", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_Screen
    {
        public class __operator_plus : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __operator_plus(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/Co3JC7OK-0uXXMe486yOmA", DisplayName = "operator plus", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Main_Screen
    {
        public class __result : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __result(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/4xhqiIdt8kGnuyJ0BQrGhQ", DisplayName = "result", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator
    {
        public class __Main_Screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Main_Screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "LcgIwV9so0Oc0ke5IBfnPQ/5U1tDRtj3UyZ8o1dAnau2g", DisplayName = "Main Screen", Screen = this};
                digit_5 = new OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__digit_5(this, null);
                digit_7 = new OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__digit_7(this, null);
                operator_equal = new OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__operator_equal(this, null);
                operator_plus = new OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__operator_plus(this, null);
                result = new OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__result(this, null);
            }

            public OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__digit_5 digit_5 { get; private set; }

            public OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__digit_7 digit_7 { get; private set; }

            public OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__operator_equal operator_equal { get; private set; }

            public OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__operator_plus operator_plus { get; private set; }

            public OR_Library_Windows_VB._Implementation._Calculator._Main_Screen.__result result { get; private set; }
        }
    }
}