using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public static PeopleViewModel stvm = new PeopleViewModel(); // Får ej annotations att fungera utan denna!
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

        [HttpPost("createPerson")]
        public IActionResult Create(CreatePersonViewModel createPerson)
        {
            if (ModelState.IsValid)
            {
                createPerson.Id = Guid.NewGuid().ToString();
                PeopleViewModel.listOfPeople.Add(new Person { Id = createPerson.Id, Name = createPerson.Name, PhoneNumber = createPerson.PhoneNumber, City = createPerson.City });
                return RedirectToAction("Index");
            }
            return View("Index", stvm);
        }

        [HttpPost("searchText")]
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
