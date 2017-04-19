using System;
using System.Net.Sockets;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace ShadowsocksMessage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}