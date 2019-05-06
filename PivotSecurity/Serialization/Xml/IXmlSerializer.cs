using PivotSecurity.Serializers;

namespace PivotSecurity.Serialization.Xml
{
    public interface IXmlSerializer : ISerializer, IWithRootElement
    {
        string Namespace { get; set; }

        string DateFormat { get; set; }
    }
}
