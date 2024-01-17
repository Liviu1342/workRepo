using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Connections_Win_VB_Library.ObjectRepository
{
    public static class Descriptors
    {
        public static class Calculator
        {
            public static _Implementation._Calculator.__Main_screen Main_screen { get; private set; } = new _Implementation._Calculator.__Main_screen();
        }

        public static class UiPath_Studio
        {
            public static _Implementation._UiPath_Studio.__Backstage Backstage { get; private set; } = new _Implementation._UiPath_Studio.__Backstage();
            public static _Implementation._UiPath_Studio.__Designer Designer { get; private set; } = new _Implementation._UiPath_Studio.__Designer();
        }
    }
}

namespace Connections_Win_VB_Library._Implementation
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
        public class __Digit_6 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Digit_6(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/eRj8mF7tcEmpIUD2NtdYwQ", DisplayName = "Digit 6", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/8OE62zkoLEKg6C4460_CwA", DisplayName = "Result", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
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
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/NlVsEdyRPk2cFKejjbHhSA", DisplayName = "Main screen", Screen = this};
                Digit_6 = new _Implementation._Calculator._Main_screen.__Digit_6(this, null);
                Result = new _Implementation._Calculator._Main_screen.__Result(this, null);
            }

            public _Implementation._Calculator._Main_screen.__Digit_6 Digit_6 { get; private set; }

            public _Implementation._Calculator._Main_screen.__Result Result { get; private set; }
        }
    }

    namespace _UiPath_Studio._Backstage
    {
        public class __Image___UiPath_Logo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Image___UiPath_Logo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/vWagjq1zXk6DTsqsPQID3w", DisplayName = "Image - UiPath Logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiPath_Studio._Backstage._Tab___Tools
    {
        public class __Template___Library : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Template___Library(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/FjTVK4x2X0CLXCqSTQ3CXw", DisplayName = "Template - Library", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiPath_Studio._Backstage
    {
        public class __Tab___Tools : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Tab___Tools(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/RNAKqpb7ikG4cMt0zTpHNA", DisplayName = "Tab - Tools", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Template___Library = new _Implementation._UiPath_Studio._Backstage._Tab___Tools.__Template___Library(screenDescriptor, this);
            }

            public _Implementation._UiPath_Studio._Backstage._Tab___Tools.__Template___Library Template___Library { get; private set; }
        }
    }

    namespace _UiPath_Studio
    {
        public class __Backstage : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Backstage()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/0PqAKb7AU0GsV5OVwrkVOA", DisplayName = "Backstage", Screen = this};
                Image___UiPath_Logo = new _Implementation._UiPath_Studio._Backstage.__Image___UiPath_Logo(this, null);
                Tab___Tools = new _Implementation._UiPath_Studio._Backstage.__Tab___Tools(this, null);
            }

            public _Implementation._UiPath_Studio._Backstage.__Image___UiPath_Logo Image___UiPath_Logo { get; private set; }

            public _Implementation._UiPath_Studio._Backstage.__Tab___Tools Tab___Tools { get; private set; }
        }
    }

    namespace _UiPath_Studio._Designer
    {
        public class __Ribbon___Design___UiExplorer : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Ribbon___Design___UiExplorer(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/XR1c3pnXKEuMgjo2HoDbpw", DisplayName = "Ribbon - Design - UiExplorer", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiPath_Studio._Designer
    {
        public class __test : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __test(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/vJQxdp9UYEaYsOPhk-5jWg", DisplayName = "test", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _UiPath_Studio
    {
        public class __Designer : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Designer()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "kRVnGAec4kCWArh1a1i6Og/a_9QNu9pSkeYE1LaKYn4Tw", DisplayName = "Designer", Screen = this};
                Ribbon___Design___UiExplorer = new _Implementation._UiPath_Studio._Designer.__Ribbon___Design___UiExplorer(this, null);
                test = new _Implementation._UiPath_Studio._Designer.__test(this, null);
            }

            public _Implementation._UiPath_Studio._Designer.__Ribbon___Design___UiExplorer Ribbon___Design___UiExplorer { get; private set; }

            public _Implementation._UiPath_Studio._Designer.__test test { get; private set; }
        }
    }
}