using KYSports1.Models.ViewModels;
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
            return View(model);
        }

        public ActionResult About()
        { 
            return View();
        }

        public ActionResult Recruiting()
        {
  
            return View();
        }
        public ActionResult NBA()
        {
            var Model = repo.GetPlayerQueryString();
            return View(Model);
        }
        public ActionResult Article()
        {
            return View();
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult ArticlesByCategory(int id)
        {
            var model = repo.GetArticlesByCategory(id);
            ViewBag.Title = model[0].Category;
            return View(model);
        }
    }
}