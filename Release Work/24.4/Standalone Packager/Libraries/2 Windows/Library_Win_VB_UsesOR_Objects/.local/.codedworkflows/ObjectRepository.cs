using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Library_Win_VB_UsesOR_Objects.ObjectRepository
{
    public static class Descriptors
    {
        public static class Google_Chrome_Browser
        {
            static string _reference = "WZXuR0MeM0KPgdn9gVo4RQ/CIRzSnK6XEKyOt5JYVf3cw";
            public static _Implementation._Google_Chrome_Browser.__Chrome___New_Tab Chrome___New_Tab { get; private set; } = new _Implementation._Google_Chrome_Browser.__Chrome___New_Tab();
        }

        public static class Windows_Calculator
        {
            static string _reference = "WZXuR0MeM0KPgdn9gVo4RQ/F33B2c86dkOFCV1HAgL-dw";
            public static _Implementation._Windows_Calculator.__Main_Screen Main_Screen { get; private set; } = new _Implementation._Windows_Calculator.__Main_Screen();
        }
    }
}

namespace Library_Win_VB_UsesOR_Objects._Implementation
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

    namespace _Google_Chrome_Browser._Chrome___New_Tab
    {
        public class __Button__New_Tab_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Button__New_Tab_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/2NljvTlkjkWqM6N8_t3aZA", DisplayName = "Button 'New Tab'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Google_Chrome_Browser._Chrome___New_Tab
    {
        public class __Input__Search_box_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Input__Search_box_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/z8ANuh8SbE6SGzGhf5nRiw", DisplayName = "Input 'Search box'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Google_Chrome_Browser
    {
        public class __Chrome___New_Tab : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome___New_Tab()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/XZA5-JDPoECPIU5cv9XZsA", DisplayName = "Chrome - New Tab", Screen = this};
                Button__New_Tab_ = new _Implementation._Google_Chrome_Browser._Chrome___New_Tab.__Button__New_Tab_(this, null);
                Input__Search_box_ = new _Implementation._Google_Chrome_Browser._Chrome___New_Tab.__Input__Search_box_(this, null);
            }

            public _Implementation._Google_Chrome_Browser._Chrome___New_Tab.__Button__New_Tab_ Button__New_Tab_ { get; private set; }

            public _Implementation._Google_Chrome_Browser._Chrome___New_Tab.__Input__Search_box_ Input__Search_box_ { get; private set; }
        }
    }

    namespace _Windows_Calculator._Main_Screen
    {
        public class __Digit_5 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Digit_5(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/3ucdVCG7JUew1HCKzL2a8w", DisplayName = "Digit 5", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Windows_Calculator._Main_Screen
    {
        public class __Digit_7 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Digit_7(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/y88oA2vdjkq2CjCwc2p-MQ", DisplayName = "Digit 7", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Windows_Calculator._Main_Screen
    {
        public class __Operator___Add : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Operator___Add(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/20aP02MgDkCMAeWDz_hyNQ", DisplayName = "Operator - Add", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Windows_Calculator._Main_Screen
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/LtE_WqItZUyY-RITeYVOgA", DisplayName = "Operator - Equals", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Windows_Calculator._Main_Screen
    {
        public class __Text___Result : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Text___Result(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/TdeLFT9xCU-wnxRAtbAjnQ", DisplayName = "Text - Result", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Windows_Calculator
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
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "WZXuR0MeM0KPgdn9gVo4RQ/9JS4zB_oUkq4QsmRTzNZvw", DisplayName = "Main Screen", Screen = this};
                Digit_5 = new _Implementation._Windows_Calculator._Main_Screen.__Digit_5(this, null);
                Digit_7 = new _Implementation._Windows_Calculator._Main_Screen.__Digit_7(this, null);
                Operator___Add = new _Implementation._Windows_Calculator._Main_Screen.__Operator___Add(this, null);
                Operator___Equals = new _Implementation._Windows_Calculator._Main_Screen.__Operator___Equals(this, null);
                Text___Result = new _Implementation._Windows_Calculator._Main_Screen.__Text___Result(this, null);
            }

            public _Implementation._Windows_Calculator._Main_Screen.__Digit_5 Digit_5 { get; private set; }

            public _Implementation._Windows_Calculator._Main_Screen.__Digit_7 Digit_7 { get; private set; }

            public _Implementation._Windows_Calculator._Main_Screen.__Operator___Add Operator___Add { get; private set; }

            public _Implementation._Windows_Calculator._Main_Screen.__Operator___Equals Operator___Equals { get; private set; }

            public _Implementation._Windows_Calculator._Main_Screen.__Text___Result Text___Result { get; private set; }
        }
    }
}