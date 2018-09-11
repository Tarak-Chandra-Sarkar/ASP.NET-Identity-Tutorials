using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AspNetIdentityTutorial.Models
{
    public class ApplicationUser : IdentityUser
    {

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("AspNetIdentityTutorial", throwIfV1Schema: false)
        {

        }
    }
}