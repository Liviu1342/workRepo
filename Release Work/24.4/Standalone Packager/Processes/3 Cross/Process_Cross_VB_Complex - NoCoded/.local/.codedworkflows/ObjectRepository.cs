using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Process_Cross_VB_Complex.ObjectRepository
{
    public static class Descriptors
    {
        public static class Google_Chrome
        {
            static string _reference = "OI2pn03xUk6R8Dap7oVIdw/BThiWhcHlU6ByYcdhItLaw";
            public static _Implementation._Google_Chrome.__Freshful_ro___Via_a_ar_trebui_să_fie_Freshful Freshful_ro___Via_a_ar_trebui_să_fie_Freshful { get; private set; } = new _Implementation._Google_Chrome.__Freshful_ro___Via_a_ar_trebui_să_fie_Freshful();
        }
    }
}

namespace Process_Cross_VB_Complex._Implementation
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

    namespace _Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful
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
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "OI2pn03xUk6R8Dap7oVIdw/ZuX-utkbxkOpfWRIfcfGgg", DisplayName = "Image - Logo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful
    {
        public class __Label___Freshlist : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Label___Freshlist(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "OI2pn03xUk6R8Dap7oVIdw/n6ijli_oKkClC51kR0__OA", DisplayName = "Label - Freshlist", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Google_Chrome
    {
        public class __Freshful_ro___Via_a_ar_trebui_să_fie_Freshful : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Freshful_ro___Via_a_ar_trebui_să_fie_Freshful()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "OI2pn03xUk6R8Dap7oVIdw/hTvLNya3NE-rwqbNUZdtxw", DisplayName = "Freshful.ro - Viața ar trebui să fie Freshful", Screen = this};
                Image___Logo = new _Implementation._Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful.__Image___Logo(this, null);
                Label___Freshlist = new _Implementation._Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful.__Label___Freshlist(this, null);
            }

            public _Implementation._Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful.__Image___Logo Image___Logo { get; private set; }

            public _Implementation._Google_Chrome._Freshful_ro___Via_a_ar_trebui_să_fie_Freshful.__Label___Freshlist Label___Freshlist { get; private set; }
        }
    }
}