using System.ComponentModel;

namespace ASP.NET_MVC.Models
{
    public class Person
    {
        public string Id { get; set; }
        [DisplayName("Name of person")]
        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
