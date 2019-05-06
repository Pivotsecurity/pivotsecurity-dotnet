using System.Runtime.Serialization;

namespace PivotSecurity.Authenticators.OAuth
{
    [DataContract]
    internal enum HttpPostParameterType
    {
        Field,
        File
    }
}
