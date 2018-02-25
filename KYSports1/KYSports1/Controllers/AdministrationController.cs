using KYSports1.Models;
using KYSports1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYSports1.Controllers
{
    public class AdministrationController : Controller
    {
        [System.Web.Mvc.HttpGet]
        public ActionResult PlayerAdd()
        {
            //need to put navbar here 
            Repo repo = new Repo();
            PlayerAddView model = new PlayerAddView();
            model.List = repo.GetAllPlayers(); 

            return View(model);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult PlayerAdd(PlayerAddView name)
        {
            string[] WholeNameArray = name.PlayerNames.Wholename.Split();

            Repo repo = new Repo();

            repo.AddPlayertoPage(WholeNameArray[0], WholeNameArray[1]);

            return RedirectToAction("PlayerAdd", "Administration");
        }
        [System.Web.Mvc.HttpGet]
        [ValidateInput(false)]
        public ActionResult CreateArticle()
        {
            ArticlePage model = new ArticlePage();
            Repo repo = new Repo();
            model.list = repo.GetNavBarCategories();
            ViewBag.Title = model.list[0].Category;
            model.categories1 = new SelectList(
                new List<SelectListItem> {
                new SelectListItem { Text="Fan Blog", Value = "1"},
                new SelectListItem { Text="Game Preview", Value = "2"},
                new SelectListItem { Text="Post-Game Analysis", Value = "3"},
                new SelectListItem { Text="Breaking News", Value = "4"},
                new SelectListItem { Text="NBA Update", Value = "5"},
                new SelectListItem { Text="Recruiting News", Value = "6"},
                new SelectListItem { Text="Random Views", Value = "7"}
                                          }, "Value", "Text"
                );
            return View(model);
        }
        [System.Web.Mvc.HttpPost]
        [ValidateInput(false)]
        public ActionResult CreateArticle(string ArticleTitle,string Author,string ArticleBody, bool CarFlg, string categories1, string ImageURL, string Description)
        {
            if (ImageURL == "")
            {
                ImageURL = "https://i.imgur.com/N6X9cEw.png";
            }
            int CategoryID = int.Parse(categories1);
            Repo repo = new Repo();
            repo.CreateNewArticle(Author, ArticleBody, ArticleTitle, CarFlg, CategoryID, ImageURL,Description);

            return RedirectToAction("ListOfArticlesAdmin", "Administration");
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult ListOfArticlesAdmin()
        {
            Repo repo = new Repo();
            ArticlePage model = new ArticlePage();
            model.list = repo.GetNavBarCategories();
            model.clist = repo.GetAllArticles();
            ViewBag.Title = model.list[0].Category;
            return View(model);
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult EditArticle(int id)
        {
            ArticlePage model = new ArticlePage();
            Repo repo = new Repo();
            model.list = repo.GetNavBarCategories();
            ViewBag.Title = model.list[0].Category;
            model.articles = repo.GetArticlesByID(id);
            model.categories1 = new SelectList(
                new List<SelectListItem> {
                new SelectListItem { Text="Fan Blog", Value = "1"},
                new SelectListItem { Text="Game Preview", Value = "2"},
                new SelectListItem { Text="Post-Game Analysis", Value = "3"},
                new SelectListItem { Text="Breaking News", Value = "4"},
                new SelectListItem { Text="NBA Update", Value = "5"},
                new SelectListItem { Text="Recruiting News", Value = "6"},
                new SelectListItem { Text="Random Views", Value = "7"}
                                          }, "Value", "Text",model.articles.CategoryID
                );
            
            return View(model);
        }
        [System.Web.Mvc.HttpPost]
        public ActionResult EditArticle(int id, string ArticleTitle, string Description,string Author, string ArticleBody, bool CarFlg, string categoriesID,string ImageURL)
        {
            if(ImageURL == "")
            {
                ImageURL = "https://i.imgur.com/N6X9cEw.png";
            }
            
            int ID = int.Parse(categoriesID);
            Articles model = new Articles();
            Repo repo = new Repo();
            model.ArticleID = id;
            model.Title = ArticleTitle;
            model.Author = Author;
            model.ArticleBody = ArticleBody;
            model.CarFlg = CarFlg;
            model.CategoryID = ID;
            model.ImageURL = ImageURL;
            model.Description = Description;
            repo.UpdateArticle(model);

            return RedirectToAction("ListOfArticlesAdmin", "Administration");
        }
        [System.Web.Mvc.HttpGet]
        public ActionResult GetArticleById(int id)
        {
            Repo repo = new Repo();
            ArticlePage model = new ArticlePage();
            model.articles = repo.GetArticlesByID(id);
            model.list = repo.GetNavBarCategories();
            ViewBag.Title = model.list[0].Category;
            return View(model);
        }
        
    }
}