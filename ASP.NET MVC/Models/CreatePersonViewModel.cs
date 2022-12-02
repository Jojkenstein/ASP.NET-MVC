using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace ASP.NET_MVC.Models
{
    public class CreatePersonViewModel
    {
        [Display(Name = "Name of person")]
        [Required]
        public string Name { get; set; }
        [DisplayName("Phone number")]
        [Required]
        public string PhoneNumber { get; set; }
        [DisplayName("Town or city")]
        [Required]
        public string City { get; set; }
    }
}