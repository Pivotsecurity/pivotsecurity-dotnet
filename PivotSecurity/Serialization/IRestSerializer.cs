using PivotSecurity.Deserializers;
using PivotSecurity.Serializers;

namespace PivotSecurity.Serialization
{
    public interface IRestSerializer : ISerializer, IDeserializer
    {
        string[] SupportedContentTypes { get; }
        
        DataFormat DataFormat { get; }

        string Serialize(Parameter parameter);
    }
}