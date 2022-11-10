using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult GuessNumber()
        {
            if (HttpContext.Session.GetString("randNr") == null)
            {
                HttpContext.Session.SetString("randNr", GamesModel.RandGen());
                GamesModel.guessCnt = 0;
                ViewBag.Set = "A new random number was generated!";
                GamesModel.guessCorr = false; // Not sure if needed for special case yet
                return View();
            }
            
            // Check for your Cookie
            if (Request.Cookies["highScore"] != null)
            {
                // HERE IS WHERE YOU ARE STUCK!!!
                List<string> hiScore = new List<GamesModel.highScore>();
                
                // Your cookie exists - grab your value and create your List

                // -------------------------------------------------------------------------
                 
                List<int> GamesModel.highScore = Request.Cookies["highScore"].Split("<BR>");

                // Taking tips from: https://social.msdn.microsoft.com/Forums/en-US/3e554fa0-c6f0-4e95-a64a-9eebef5dd064/store-list-in-cookie-retrieve-list-from-cookie?forum=aspgettingstarted
                // Check for your Cookie
                //if (Request.Cookies["YourList"] != null)
                //{
                // Your cookie exists - grab your value and create your List
                //List<int> yourList = Request.Cookies["YourList"].Value.Split(',').Select(x => Convert.ToInt32(x)).ToList();

                // Use your list here
                //}

                // -------------------------------------------------------------------------



                // Use your list here

                return View();
        }

        [HttpPost]
        public IActionResult GuessNumber(string guessNr)
        {
            if (guessNr != null)
            {
                //Regenerate randNr in session if needed
                if ((HttpContext.Session.GetString("randNr") == null) || (GamesModel.guessCorr == true))
                {
                    if (HttpContext.Session.GetString("randNr") == null)
                    {
                        HttpContext.Session.SetString("randNr", GamesModel.RandGen());
                        GamesModel.guessCnt = 0;
                        ViewBag.Reset = "A new random number was generated!";
                        GamesModel.guessCorr = false; // Not sure if needed for special case yet
                        return View();
                    }
                    HttpContext.Session.SetString("randNr", GamesModel.RandGen());
                    GamesModel.guessCnt = 0;
                    GamesModel.guessCorr = false;
                }

                GamesModel.guessCnt++;
                HttpContext.Session.SetString("guessCnt", GamesModel.guessCnt.ToString());
                ViewBag.Counter = $"Amount of guesses this rand: {GamesModel.guessCnt}";
                int guessNrInt = Int32.Parse(guessNr);

                // If for some reason randNr is null just create a new one from scratch.
                // This is to get rid of warning CS8604 - Possible null reference argument for parameter.
                int randNrSesInt = Int32.Parse(HttpContext.Session.GetString("randNr") ?? GamesModel.RandGen()); 
                ViewBag.Result = GamesModel.EvalGuess(guessNrInt, randNrSesInt);
                                
                if (GamesModel.guessCorr == true)
                {
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.UtcNow.AddMinutes(5);
                    HttpContext.Response.Cookies.Append("highScore", GamesModel.HighScoreJoined(), options);

                    ViewBag.Reset = "A new random number will be generated.";
                }
            }
            else
            {
                ViewBag.Result = "Your submit was empty. Please try again.";
            }
            return View();
        }
    }
}
