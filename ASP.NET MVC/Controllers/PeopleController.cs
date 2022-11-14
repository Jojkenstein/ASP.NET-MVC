using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            /*if (ModelState.IsValid)*/ //ModelState.IsValid fungerar ej
            
                if (CreatePersonViewModel.listOfPeople.Count == 0)
                {
                    CreatePersonViewModel.GeneratePeople();
                }

                if (CreatePersonViewModel.filtered.Count > 0)
                {
                    PersonViewModel vm2 = new PersonViewModel();
                    vm2.tempList = CreatePersonViewModel.filtered;
                    CreatePersonViewModel.filtered = CreatePersonViewModel.emptyList; // FULfix då CreatePersonViewModel.filtered.Clear(); raderar alla listor
                    return View(vm2);
                }
            
            PersonViewModel vm = new PersonViewModel();
            vm.tempList = CreatePersonViewModel.listOfPeople;
            return View(vm);
        }
        public IActionResult CreateOrSearch()
        {//HÄR FÅR JAG NOG LÄGGA IN !=null-SKYDD eller vänta, behövs denna ens???
            return RedirectToAction("Index");
        }
        [HttpPost("person")]
        public IActionResult Create(Person person)
        {
            /*if (ModelState.IsValid)*/ //FUNGERAR EJ
            
                
                if (person.Name != null)
                {
                    person.Id = Guid.NewGuid().ToString();
                    CreatePersonViewModel.listOfPeople.Add(person);
                }
            
            return RedirectToAction("Index");
        }
        [HttpPost("searchText")]
        public IActionResult Search(string searchText)
        {
            /*if (ModelState.IsValid)*/ //FUNGERAR EJ
            
                if (searchText != null)
                {
                    string searchString = searchText;
                    PersonViewModel vm = new PersonViewModel();
                    vm.tempList = CreatePersonViewModel.listOfPeople;

                    CreatePersonViewModel.filtered = PersonViewModel.Search(searchString, vm.tempList);

                }
               
            
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            var personToDelete = CreatePersonViewModel.listOfPeople.FirstOrDefault(x => x.Id == id);
            if (personToDelete != null)
            {
                CreatePersonViewModel.listOfPeople.Remove(personToDelete);
            }
            return RedirectToAction("Index");
        }
    }
}
