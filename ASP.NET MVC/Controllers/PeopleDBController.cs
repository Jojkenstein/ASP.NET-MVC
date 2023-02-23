using ASP.NET_MVC.Data;
using ASP.NET_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC.Controllers
{
    public class PeopleDBController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleDBController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.People.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                person.Id = Guid.NewGuid().ToString();
                _context.People.Add(person);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            if (id != null)
            {
                Person personToDelete = _context.People.Find(id);
                if (personToDelete != null)
                {
                    _context.People.Remove(personToDelete);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
