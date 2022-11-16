namespace ASP.NET_MVC.Models
{
    public class PeopleViewModel
    {
        public static List<Person> listOfPeople = new List<Person>();
        public List<Person> tempList = new List<Person>(); // t.ex. för filtrering utan att förstöra original-listan
        public string searchText { get; set; }

        public CreatePersonViewModel createPerson { get; set; } // Adderad efter feedback

        public static void GeneratePeople()
        {
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Jay Kay", City = "Stockholm", PhoneNumber = "555-692471337" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Mike Truk", City = "Dallas", PhoneNumber = "555-702571234" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Bobson Dugnut", City = "New York", PhoneNumber = "555-882475678" });
        }

        public static List<Person> Search(string searchString, List<Person> listToFilter)
        {
            searchString = searchString.ToLower();
            var listToSend = listToFilter.FindAll(x => x.Name.ToLower().Contains(searchString)||x.City.ToLower().Contains(searchString));
            return listToSend;
        }
    }
}
