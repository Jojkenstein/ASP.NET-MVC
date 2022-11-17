using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            if (PeopleViewModel.listOfPeople.Count == 0)
            {
                PeopleViewModel.GeneratePeople();
            }
            PeopleViewModel vm = new PeopleViewModel();
            vm.tempList = PeopleViewModel.listOfPeople;
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                PeopleViewModel.listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = createPerson.Name, PhoneNumber = createPerson.PhoneNumber, City = createPerson.City });
                return RedirectToAction("Index");
            }
            PeopleViewModel vm = new PeopleViewModel();
            vm.tempList = PeopleViewModel.listOfPeople;
            return View("Index", vm);
        }
        [HttpPost]
        public IActionResult Search(string searchText)
        {
            if (searchText != null)
            {
                string searchString = searchText;
                PeopleViewModel vm = new PeopleViewModel();
                vm.tempList = PeopleViewModel.Search(searchString, PeopleViewModel.listOfPeople);
                return View("Index", vm);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            var personToDelete = PeopleViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (personToDelete != null)
            {
                PeopleViewModel.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }
    }
}
