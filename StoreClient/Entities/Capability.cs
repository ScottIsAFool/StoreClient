using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    public class Capability
    {
        internal Capability(ZuneApp.capabilitiesCapability capabilities)
        {
            CapabilityType = CapabilityType.Software;
            Id = capabilities.id;
            Name = capabilities.@string;
        }

        internal Capability(ZuneApp.capabilitiesHwCapability capabilities)
        {
            CapabilityType = CapabilityType.Hardware;
            Id = capabilities.id;
            Name = capabilities.@string;
        }

        public CapabilityType CapabilityType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}