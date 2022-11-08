using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class Doctor : Controller
    {
        //HttpGet
        public IActionResult Temperature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Temperature(string temperature, string scale)
        {
            ViewBag.Result = DoctorModel.CheckTemperature(temperature, scale);

            return View();
        }
    }
}
