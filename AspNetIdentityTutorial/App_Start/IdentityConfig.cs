using AspNetIdentityTutorial.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetIdentityTutorial
{
    public class ApplicationUserStore : UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext context)
            :base(context)
        {

        }
    }

    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager( IUserStore<ApplicationUser> store)
            :base(store)
        {

        }
    }


}