using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Library_Win_CS_UsesOR_Objects.ObjectRepository
{
    public static class Descriptors
    {
        public static class Notepad__
        {
            static string _reference = "8o_l5S6E60iSBdtMeczXSg/eCbXNPOZZUm_QDFKr6tlhA";
            public static _Implementation._Notepad__.__Main_Screen Main_Screen { get; private set; } = new _Implementation._Notepad__.__Main_Screen();
        }
    }
}

namespace Library_Win_CS_UsesOR_Objects._Implementation
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

    namespace _Notepad__._Main_Screen
    {
        public class __Button___Save : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Button___Save(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8o_l5S6E60iSBdtMeczXSg/7YYh_dr3C0SayoHHw7Y9SA", DisplayName = "Button - Save", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Notepad__._Main_Screen
    {
        public class __Input___Text_Area : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Input___Text_Area(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8o_l5S6E60iSBdtMeczXSg/d1PJ1af2_ky_JOcu9z2QOw", DisplayName = "Input - Text Area", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Notepad__
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
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "8o_l5S6E60iSBdtMeczXSg/dMifPljs202yovpqSaVK9Q", DisplayName = "Main Screen", Screen = this};
                Button___Save = new _Implementation._Notepad__._Main_Screen.__Button___Save(this, null);
                Input___Text_Area = new _Implementation._Notepad__._Main_Screen.__Input___Text_Area(this, null);
            }

            public _Implementation._Notepad__._Main_Screen.__Button___Save Button___Save { get; private set; }

            public _Implementation._Notepad__._Main_Screen.__Input___Text_Area Input___Text_Area { get; private set; }
        }
    }
}