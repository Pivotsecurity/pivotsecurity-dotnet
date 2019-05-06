using System.Runtime.Serialization;

namespace PivotSecurity.Authenticators.OAuth
{
    [DataContract]
    public enum OAuthSignatureTreatment
    {
        Escaped,
        Unescaped
    }
}
