using APILayer.Models;
using DomainLayer;
using DomainLayer.Product;
using Microsoft.Extensions.Configuration;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UILayer.Datas.Apiservices
{
    public class ProductApi
    {

        string _url;
        IConfiguration _configuration;
        public ProductApi(IConfiguration configuration)
        {
            _configuration = configuration;
            _url = _configuration.GetSection("Development")["BaseApi"].ToString();
        }
        public IEnumerable<ProductsModel> GetProduct()
        {
            using (HttpClient httpclient = new HttpClient())
            {

<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory";
=======
                string url = _url + "api/ProductCatagory";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    var results = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<ProductsModel>>(response.Result);
                    return results;
                }
                return null;
            }

        }

        public ProductsModel GetById(int id)
        {

            using (HttpClient httpClient = new HttpClient())
            {
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/ProductCatagory/Details/" + id;
=======
                string url = _url + "api/ProductCatagory/ProductCatagory/Details/" + id;
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                Task<HttpResponseMessage> result = httpClient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    Task<string> serilizedResult = result.Result.Content.ReadAsStringAsync();
                    var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductsModel>(serilizedResult.Result);
                    return products;
                }
                return null;
            }

        }



        public  bool Edit(ProductsModel product)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(product);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/ProductPut";
=======
                string url = _url + "api/ProductCatagory/ProductPut";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                HttpResponseMessage response = httpclient.PutAsync(uri, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
        public  bool Create(ProductsModel product)
        {

            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(product);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/ProductPost";
=======
                string url = _url+ "api/ProductCatagory/ProductPost";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> response = httpclient.PostAsync(uri, content);

                if (response.Result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }

        public  bool Delete(int id)
        {
            using (HttpClient httpclient = new HttpClient())
            {
                string data = Newtonsoft.Json.JsonConvert.SerializeObject(id);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/productcatagory/ProductDelete/" + id;
=======
                string url = _url + "api/productcatagory/ProductDelete/" + id;
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
        public IEnumerable<ProductsModel> ProductSearch(string name)
        {
            using (HttpClient httpclient = new HttpClient())
            {

<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/ProductSearch/" + name;
=======
                string url = _url + "api/ProductCatagory/ProductSearch/" + name;
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    var results = Newtonsoft.Json.JsonConvert.DeserializeObject<Response<IEnumerable<ProductsModel>>>(response.Result);
                    return results.Data;
                }
                return null;
            }

        }
        public async Task<IEnumerable<ProductsModel>> Filter(string name)
        {
            using (HttpClient httpclient = new HttpClient())
            {

<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/FilterByBrand";
=======
                string url = _url+ "api/ProductCatagory/FilterByBrand";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();
                    var results = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<ProductsModel>>(response.Result);
                    return results;
                }
                return null;
            }
        }

        public async Task<IEnumerable<ProductsModel>> SortByAscending(string price)

        {
            using (HttpClient httpclient = new HttpClient())
            {

<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/SortByPriceAscending";
=======
                string url = _url + "api/ProductCatagory/SortByPriceAscending";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();

                    var results = Newtonsoft.Json.JsonConvert.DeserializeObject<Response<IEnumerable<ProductsModel>>>(response.Result);
                    return results.Data;
                }
                return null;
            }
        }

        public async Task<IEnumerable<ProductsModel>> SortbyDescending(string price)

        {
            using (HttpClient httpclient = new HttpClient())
            {
<<<<<<< HEAD
                string url = "http://mobizoneappapi.azurewebsites.net/api/ProductCatagory/SortByPriceDescending";
=======
                string url = _url + "api/ProductCatagory/SortByPriceDescending";
>>>>>>> 5f75dce84670d2a7a8ed1c330a39b392fbb88225
                Uri uri = new Uri(url);
                System.Threading.Tasks.Task<HttpResponseMessage> result = httpclient.GetAsync(uri);
                if (result.Result.IsSuccessStatusCode)
                {
                    System.Threading.Tasks.Task<string> response = result.Result.Content.ReadAsStringAsync();

                    var results = Newtonsoft.Json.JsonConvert.DeserializeObject<Response<IEnumerable<ProductsModel>>>(response.Result);
                    return results.Data;
                }
                return null;
            }
        }
    }
}
