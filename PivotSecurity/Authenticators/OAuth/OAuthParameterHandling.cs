using System.Runtime.Serialization;

namespace PivotSecurity.Authenticators.OAuth
{
    [DataContract]
    public enum OAuthParameterHandling
    {
        HttpAuthorizationHeader,
        UrlOrPostParameters
    }
}
