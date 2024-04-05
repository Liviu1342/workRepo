using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Library_Cross_VB_UsesOR_Objects.ObjectRepository
{
    public static class Descriptors
    {
        public static class __City_Grill_UiPath
        {
            static string _reference = "GJVfdA7Oj02fvi4000kkOQ/3gJuiE5glkaTGOgCtBMEAQ";
            public static _Implementation.___City_Grill_UiPath.__City_Grill_UiPath City_Grill_UiPath { get; private set; } = new _Implementation.___City_Grill_UiPath.__City_Grill_UiPath();
        }
    }
}

namespace Library_Cross_VB_UsesOR_Objects._Implementation
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

    namespace ___City_Grill_UiPath._City_Grill_UiPath
    {
        public class __Button___Acasa : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Button___Acasa(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "GJVfdA7Oj02fvi4000kkOQ/RjnecjQgFEeGX843383tTQ", DisplayName = "Button - Acasa", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___City_Grill_UiPath._City_Grill_UiPath
    {
        public class __Button___Info_mic_dejun : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Button___Info_mic_dejun(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "GJVfdA7Oj02fvi4000kkOQ/oscG7eIPHU6drjjQkGrtPA", DisplayName = "Button - Info mic dejun", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___City_Grill_UiPath._City_Grill_UiPath
    {
        public class __Image___Logo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Image___Logo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "GJVfdA7Oj02fvi4000kkOQ/xis-fOdBcUuDGdnvbaa1eA", DisplayName = "Image - Logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace ___City_Grill_UiPath
    {
        public class __City_Grill_UiPath : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __City_Grill_UiPath()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "GJVfdA7Oj02fvi4000kkOQ/idD0eoS6_EOyy6KNrpUqsA", DisplayName = "City Grill UiPath", Screen = this};
                Button___Acasa = new _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Button___Acasa(this, null);
                Button___Info_mic_dejun = new _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Button___Info_mic_dejun(this, null);
                Image___Logo = new _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Image___Logo(this, null);
            }

            public _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Button___Acasa Button___Acasa { get; private set; }

            public _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Button___Info_mic_dejun Button___Info_mic_dejun { get; private set; }

            public _Implementation.___City_Grill_UiPath._City_Grill_UiPath.__Image___Logo Image___Logo { get; private set; }
        }
    }
}