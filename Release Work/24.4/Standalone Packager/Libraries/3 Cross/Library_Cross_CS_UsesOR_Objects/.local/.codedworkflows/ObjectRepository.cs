using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Library_Cross_CS_UsesOR_Objects.ObjectRepository
{
    public static class Descriptors
    {
        public static class __Home___Automation_Cloud
        {
            static string _reference = "JhCuiz1ywkG_jcKEE4Iqbw/RwJfc6If2kuISWtGzbbYHg";
            public static _Implementation.___Home___Automation_Cloud.__Home___Automation_Cloud Home___Automation_Cloud { get; private set; } = new _Implementation.___Home___Automation_Cloud.__Home___Automation_Cloud();
        }
    }
}

namespace Library_Cross_CS_UsesOR_Objects._Implementation
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

    namespace ___Home___Automation_Cloud._Home___Automation_Cloud
    {
        public class __Image___Mascot : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Image___Mascot(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "JhCuiz1ywkG_jcKEE4Iqbw/N4VZ-kFhHki-HclWRH0aCQ", DisplayName = "Image - Mascot", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___Home___Automation_Cloud._Home___Automation_Cloud
    {
        public class __Image___UiPath_logo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Image___UiPath_logo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "JhCuiz1ywkG_jcKEE4Iqbw/Un1JPbD6SUW8N7sH-VVnwA", DisplayName = "Image - UiPath logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___Home___Automation_Cloud._Home___Automation_Cloud
    {
        public class __Label___Welcome_Text : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Label___Welcome_Text(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "JhCuiz1ywkG_jcKEE4Iqbw/RR5_1E3Z30S9BQcLox6ZIw", DisplayName = "Label - Welcome Text", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___Home___Automation_Cloud
    {
        public class __Home___Automation_Cloud : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Home___Automation_Cloud()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "JhCuiz1ywkG_jcKEE4Iqbw/jvx796RX-EC2olPFZJVT5g", DisplayName = "Home - Automation Cloud", Screen = this};
                Image___Mascot = new _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Image___Mascot(this, null);
                Image___UiPath_logo = new _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Image___UiPath_logo(this, null);
                Label___Welcome_Text = new _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Label___Welcome_Text(this, null);
            }

            public _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Image___Mascot Image___Mascot { get; private set; }

            public _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Image___UiPath_logo Image___UiPath_logo { get; private set; }

            public _Implementation.___Home___Automation_Cloud._Home___Automation_Cloud.__Label___Welcome_Text Label___Welcome_Text { get; private set; }
        }
    }
}