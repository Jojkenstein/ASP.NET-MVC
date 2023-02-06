using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ASP.NET_MVC.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetPeople()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
            {
                PeopleViewModel.GeneratePeople();
            }
            List<Person> people = PeopleViewModel.listOfPeople;
            return PartialView("_peoplePartialAjax", people);
        }

        [HttpPost]
        public IActionResult GetDetails(string id)
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
            {
                PeopleViewModel.GeneratePeople();
            }
            Person person = PeopleViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                return PartialView("_personPartialAjax", person);
            }
            return PartialView("_notFoundPartialAjax");
        }

        [HttpPost]
        public IActionResult DeletePerson(string id)
        {
            var personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
                return PartialView("_deletePartialAjax", personToDelete);
            }
            return PartialView("_notFoundPartialAjax");
        }
    }
}
