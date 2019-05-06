using System.Runtime.Serialization;

namespace PivotSecurity.Authenticators.OAuth
{
    [DataContract]
    public enum OAuthType
    {
        RequestToken,
        AccessToken,
        ProtectedResource,
        ClientAuthentication
    }
}
