﻿using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
