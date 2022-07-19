using APILayer.Models;
using DomainLayer;
using DomainLayer.EmailService;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UILayer.Datas.Apiservices
{
    public class UserApi
    {
        string _url;
        IConfiguration _configuration;
        public UserApi(IConfiguration configuration)
        {
            _configuration = configuration;
            _url = _configuration.GetSection("Development")["BaseApi"].ToString();
        }
        public bool UserRegister(Registration user)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/SignUp";
=======
                string url = _url + "api/User/SignUp";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PostAsync(uri, content);
                if (result.Result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }

        /*public bool UserLogin(Login userLogin)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(userLogin);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/SignIn";
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PostAsync(uri, content);
                if (result.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
        }*/

        public IEnumerable<Registration> GetUserInfo()
        {

            UserResponse<IEnumerable<Registration>> _responseModel = new UserResponse<IEnumerable<Registration>>();
            using (HttpClient httpclient = new HttpClient())
            {              
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/GetUser";
=======
                string url = _url + "api/User/GetUser";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    _responseModel.result = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Registration>>(response.Result);
                }
                return _responseModel.result;
            }
        }
        public bool UserLogin(Login userLogin)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(userLogin);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/UserLogin";
=======
                string url = _url + "api/User/UserLogin";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PostAsync(uri, content);
                if (result.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
        }
        public bool EditUserInfo(Registration userInfo)
        {
            using (HttpClient httpclient = new HttpClient())
{
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(userInfo);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/UpdateUser";
=======
                string url = _url + "api/User/UpdateUser";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PutAsync(uri, content);
                if (result.Result.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
        }
        public bool ForgotPassword(Registration resetPassword)
        {
            ResetPasswordCredential reset = new ResetPasswordCredential();
            reset.email = resetPassword.email;
            reset.password = resetPassword.password;
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(reset);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/User/ResetPassword/";
=======
                string url = _url + "api/User/ResetPassword/";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PostAsync(uri, content);
                if (result.Result.IsSuccessStatusCode)
                {
                    return true;
                }

                return false;
            }
        }
        public bool Email(Email email)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(email);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/SendEmail/Send";
=======
                string url = _url + "api/SendEmail/Send";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.PostAsync(uri, content);
                if (result.Result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
