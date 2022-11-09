using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult SetGuessNr()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetGuessNr(string guessNr)
        {
            //Make sure session is set
            if (guessNr != null)
            {
                HttpContext.Session.SetString("guessNr", guessNr);
            }
            if (HttpContext.Session.GetString("randNr") == null)
            {
                HttpContext.Session.SetString("randNr", GamesModel.RandGen());
            }

            //Make sure values are read from (updated) session
            if ((HttpContext.Session.GetString("guessNr") != null) && (HttpContext.Session.GetString("randNr") != null))
            {
                int guessNrIntSes = Int32.Parse(HttpContext.Session.GetString("guessNr"));
                int randNrIntSes = Int32.Parse(HttpContext.Session.GetString("randNr"));
                ViewBag.Result = GamesModel.EvalGuess(guessNrIntSes, randNrIntSes);
            }
            return View();
        }
    }
}
