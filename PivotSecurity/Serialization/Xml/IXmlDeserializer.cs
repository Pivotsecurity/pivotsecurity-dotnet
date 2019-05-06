using PivotSecurity.Deserializers;

namespace PivotSecurity.Serialization.Xml
{
    public interface IXmlDeserializer : IDeserializer
    {
        string RootElement { get; set; }

        string Namespace { get; set; }

        string DateFormat { get; set; }
    }
}