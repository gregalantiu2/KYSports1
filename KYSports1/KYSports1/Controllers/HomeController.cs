using KYSports1.Models;
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
        public ActionResult NavBar()
        {
            var model = new List<Articles>();
            model = repo.GetAllArticles();
            return View(model);
        }
        public ActionResult About()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetAllArticles();
            return View(model);
        }

        public ActionResult Recruiting()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetAllArticles();
            return View(model);
        }
        public ActionResult NBA()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetAllArticles();
            model.pstring = repo.GetPlayerQueryString();
            return View(model);
        }
        public ActionResult ContactUs()
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetAllArticles();
            return View(model);
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult ArticlesByCategory(int id)
        {
            ArticlePage model = new ArticlePage();
            model.list = repo.GetAllArticles();
            model.clist = repo.GetArticlesByCategory(id);
            ViewBag.Title = model.clist[0].Category;
            return View(model);
        }
    }
}