using DomainLayer.Orders;
using DomainLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using UILayer.ApiServices;
using UILayer.Datas.Apiservices;
using NPOI.OpenXml4Net.OPC;
using Microsoft.Extensions.Configuration;

namespace UILayer.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly UserApi _userApi;
        private readonly AdminApi _adminApi;
        private readonly OrdersApi _ordersApi;
        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
            _adminApi = new AdminApi();
            _userApi = new UserApi(_configuration);
            _ordersApi = new OrdersApi(_configuration);
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("Login");
        }
        [Authorize]
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Userdata()
        {
            var _userlist = _adminApi.GetUserData();

            return View(_userlist);
        }

    }
}