namespace ASP.NET_MVC.Models
{
    public class CreatePersonViewModel
    {
        public static List<Person> listOfPeople = new List<Person>();
        public static List<Person> filtered = new List<Person>(); // To be able to have two forms on one view
        public static List<Person> emptyList = new List<Person>(); // FULfix då CreatePersonViewModel.filtered.Clear(); raderar alla listor
        

        public static void GeneratePeople()
        {//Testar med City och PhoneNumber i "fel" ordning
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Jay Kay", City = "Stockholm", PhoneNumber = "555-692471337" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Mike Truk", City = "Dallas", PhoneNumber = "555-702571234" });
            listOfPeople.Add(new Person { Id = Guid.NewGuid().ToString(), Name = "Bobson Dugnut", City = "New York", PhoneNumber = "555-882475678" });
        }
    }
}
