using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace ASP.NET_MVC.Models
{
    public class CreatePersonViewModel
    {
        [DisplayName("Id#")]
        public string? Id { get; set; }  // -?
        [Display(Name = "Name of person")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Phone number")]
        [Required]
        public string PhoneNumber { get; set; } // -?
        [DisplayName("Town or city")]
        [Required]
        public string City { get; set; } // -?

        //public static List<Person> filtered = new List<Person>(); // To be able to have two forms on one view
        //public static List<Person> emptyList = new List<Person>(); // FULfix då CreatePersonViewModel.filtered.Clear(); raderar alla listor


    }
}