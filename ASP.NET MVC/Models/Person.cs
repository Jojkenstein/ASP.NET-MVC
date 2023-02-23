using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public string City { get; set; }
    }
}
