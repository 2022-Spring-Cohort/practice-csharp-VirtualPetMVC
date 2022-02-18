using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace VirtualPetMVC.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}
