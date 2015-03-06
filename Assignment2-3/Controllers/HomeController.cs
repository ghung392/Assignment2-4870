using Assignment2_3.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*using (var context = new ApplicationDbContext())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                roleManager.Create(new IdentityRole("Administrator"));

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = userManager.FindByEmail("adam@gs.ca");
                //userManager.AddPassword(user.Id, "P@$$w0rd");
                userManager.AddToRole(user.Id, "Administrator");

                user = userManager.FindByEmail("wendy@gs.ca");
               // userManager.AddPassword(user.Id, "P@$$w0rd");
                userManager.AddToRole(user.Id, "Worker");

                user = userManager.FindByEmail("rob@gs.ca");
                //userManager.AddPassword(user.Id, "P@$$w0rd");
                userManager.AddToRole(user.Id, "Reporter");

                context.SaveChanges();
            }*/
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}