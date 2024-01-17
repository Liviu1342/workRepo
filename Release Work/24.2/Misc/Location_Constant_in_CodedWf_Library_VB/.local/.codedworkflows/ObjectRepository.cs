using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Location_Constant_in_CodedWf_Library_VB.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace Location_Constant_in_CodedWf_Library_VB._Implementation
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
}