using Microsoft.AspNetCore.Identity;

namespace DollyHotel.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string? FirstName { get; set; }

        [PersonalData]
        public string? LastName { get; set; }

        [PersonalData]
        public string? MobileNumber { get; set; }


        [PersonalData]
        public DateTime? RegistrationDate { get; set; }
    }
}