using APILayer.Models;
using DomainLayer.AddToCart;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UILayer.ApiServices.AddToCart
{
    public class CartDetailsOperationApi
    {
        string _url;
        IConfiguration _configuration;
        public CartDetailsOperationApi(IConfiguration configuration)
        {
            _configuration = configuration;
            _url = _configuration.GetSection("Development")["BaseApi"].ToString();
        }

        [HttpGet("CartDatas")]
        public IEnumerable<CartDetails> CartDetailsDatas()
        {

            UserResponse<IEnumerable<CartDetails>> _responseModel = new UserResponse<IEnumerable<CartDetails>>();
            using (HttpClient httpclient = new HttpClient())
            {

<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/CartDetailsOperation/GetCart";
=======
                string url = _url + "api/CartDetailsOperation/GetCart";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    _responseModel.result = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<CartDetails>>(response.Result);
                }

                return _responseModel.result;
            }
        }

        public bool EditCartDetailsData(CartDetails cart)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(cart);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/CartDetailsOperation/CartDetailsPut";
=======
                string url = _url + "api/CartDetailsOperation/CartDetailsPut";
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
        public bool AddCartDetailsData(CartDetails cart)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(cart);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/CartDetailsOperation/CartDetailsAdd";
=======
                string url = _url + "api/CartDetailsOperation/CartDetailsAdd";
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
        public bool DeleteCartDetailsData(int id)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(id);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/CartDetailsOperation/CartDetailsDelete/" + id;
=======
                string url = _url + "api/CartDetailsOperation/CartDetailsDelete/" + id;
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> response = httpclient.DeleteAsync(uri);

                if (response.Result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
