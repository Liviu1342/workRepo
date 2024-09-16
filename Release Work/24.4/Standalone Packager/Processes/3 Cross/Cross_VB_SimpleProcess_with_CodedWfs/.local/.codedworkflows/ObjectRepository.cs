using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Cross_VB_SimpleProcess_with_CodedWfs.ObjectRepository
{
    public static class Descriptors
    {
    }
}

namespace Cross_VB_SimpleProcess_with_CodedWfs._Implementation
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