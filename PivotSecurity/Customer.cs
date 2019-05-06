using PivotSecurity.Authenticators;
using System;
using System.Collections.Generic;
using System.Text;

namespace PivotSecurity
{
    class Customer
    {
        private static string public_key = "";
        private static string private_key = "";
        public Customer(string _public_key, string _private_key)
        {
            Customer.public_key = _public_key;
            Customer.private_key = _private_key;
        }

        public string AuthenticateCustomer(string uid, string email, string code)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("customer/auth");
            client.Authenticator = new HttpBasicAuthenticator(public_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
        public string VerifyCustomer(string uid, string email, string code)
        {
            var client = new RestClient("https://api.povotsecurity.com/api/");
            var request = new RestRequest("customer/verify");
            client.Authenticator = new HttpBasicAuthenticator(public_key, "");
            request.AddJsonBody("{\"uid\":\"" + uid + "\", \"email\":\"" + email + "\", \"code\":\"" + code + "\"}");
            var response = client.Post(request);
            return response.Content;
        }
    }
}
