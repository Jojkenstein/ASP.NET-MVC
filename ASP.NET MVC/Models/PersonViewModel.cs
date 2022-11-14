namespace ASP.NET_MVC.Models
{
    public class PersonViewModel
    {
        public List<Person> tempList = new List<Person>(); // t.ex. för filtrering utan att förstöra original-listan
        public Person person { get; set; }
        public string searchText { get; set; }

        public static List<Person> Search(string searchString, List<Person> listToFilter)
        {
            searchString = searchString.ToLower();
            var listToSend = listToFilter.FindAll(x => x.Name.ToLower().Contains(searchString)||x.City.ToLower().Contains(searchString));
            return listToSend;
        }
    }
}
