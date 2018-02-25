using KYSports1.Models;
using KYSports1.Models.Identity;
using KYSports1.Models.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace KYSports1.Controllers
{
    public class HomeController : Controller
    {
        public Repo repo = new Repo();

        public ActionResult Index()
        {
            Homepage model = new Homepage(); 
            model.gameDetails = repo.GetNextGame();
            model.articles = repo.GetCarouselArticles();
            model.navbar = repo.GetNavBarCategories();
            return View(model);
        }
        public ActionResult NavBar()
        {
            var model = new List<Articles>();
            model = repo.GetNavBarCategories();
            return View(model);
        }
        public ActionResult About()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            return View(model);
        }

        public ActionResult Recruiting()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            return View(model);
        }
        public ActionResult NBA()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            model.pstring = repo.GetPlayerQueryString();
            return View(model);
        }
        public ActionResult ContactUs()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            return View(model);
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult ArticlesByCategory(int id)
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            model.clist = repo.GetArticlesByCategory(id);
            ViewBag.Title = model.clist[0].Category;
            return View(model);
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult Login()
        {
            var model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            return View(model);
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ArticlePage model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userManager = HttpContext.GetOwinContext().GetUserManager<UserManager<AppUser>>();
            var authManager = HttpContext.GetOwinContext().Authentication;

            // attempt to load the user with this password
            AppUser user = userManager.Find(model.login.UserName, model.login.Password);

            // user will be null if the password or user name is bad
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");

                return View(model);
            }
            else
            {
                // successful login, set up their cookies and send them on their way
                var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new AuthenticationProperties { IsPersistent = model.login.RememberMe }, identity);

                if (!string.IsNullOrEmpty(returnUrl))
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("Index");
            }
        }
    }
}