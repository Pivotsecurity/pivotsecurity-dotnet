using PivotSecurity.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PivotSecurity
{
    class Account
    {
        private static string public_key = "";
        private static string private_key = "";

        public Account(string _public_key, string _private_key)
        {
            Account.public_key = _public_key;
            Account.private_key = _private_key;
        }

        public string CreateCustomer(string uid, string email, string channel)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/info");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"channel\":\"" + channel + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public CustomerInfo Info(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/info");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\""+uid+"\", \"email\":\""+email+"\"}");
            var response = client.Post(request);
            CustomerInfo customerInfo = JsonConvert.DeserializeObject<CustomerInfo>(response.Content);
            return customerInfo;
        }
        public string RiskScore(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/riskscore");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }

        public string QRCode(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/qrcode");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string AuthCode(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/info");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public List<AccessLog> AccessLogs(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/logs");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            List<AccessLog> accessLogs = JsonConvert.DeserializeObject<List<AccessLog>>(response.Content);
            return accessLogs;
        }
        public string Lock(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/lock");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string Unlock(string uid, string email)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/unlock");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string TrainMachineLearning(string uid, string email, string csvdata)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/trainml");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"data\":\""+csvdata+"\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string TestMachineLearning(string uid, string email, string csvdata)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/info");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"data\":\"" + csvdata + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string GetAuthWithMetaData(string uid, string email, string metadata)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/authwithmetadata");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"metadata\":\"" + metadata + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string SendAuthCodeWithMetadata(string uid, string email, string metadata)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/sendauthwithmetadata");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"metadata\":\"" + metadata + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string VerifyAuthWithMetadata(string uid, string email, string code)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/verifywithmetadata");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"code\":\"" + code + "\"}");
            var response = client.Post(request);
            return response.Content;

        }
        public string VerifySessio(string uid, string email, string sessionid)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("account/verifysession");
            client.Authenticator = new HttpBasicAuthenticator(private_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"sessionid\":\"" + sessionid + "\"}");
            var response = client.Post(request);
            return response.Content;

        }

    }
}
