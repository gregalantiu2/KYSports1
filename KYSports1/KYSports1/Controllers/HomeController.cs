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
        public ActionResult Index()
        {
            Repo Repo = new Repo();
            Homepage model = new Homepage(); 
            model.gameDetails = Repo.GetNextGame();
            model.articles = Repo.GetCarouselArticles();
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
            Repo repo = new Repo();
            var Model = repo.GetPlayerQueryString();
            return View(Model);
        }
        public ActionResult Article()
        {
            return View();
        }
    }
}