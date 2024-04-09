using Eco_Tanger.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Eco_Tanger.Models
{
    public class Citizen
    {
        [Key]
        public string CitizenId { get; set; }

        public ApplicationUser? User { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public Citizen() { }
    }
}