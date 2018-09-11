using AspNetIdentityTutorial.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AspNetIdentityTutorial.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser {UserName=model.Email, Email=model.Email};
                var store = new ApplicationUserStore(new ApplicationDbContext());
                var userManager = new ApplicationUserManager(store);

                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                //ModelState.AddModelError("", result.Errors);
            }
            return View(model);
        }
    }
}