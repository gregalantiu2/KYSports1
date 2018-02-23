using KYSports1.Models;
using KYSports1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYSports1.Controllers
{
    public class MiniGamesController : Controller
    {
        public ActionResult UKBingo()
        {
            ArticlePage model = new ArticlePage();
            Repo repo = new Repo();
            model.list = repo.GetCarouselArticles();
            model.bingo = repo.GetBingoText();
            return View(model);
        }
    }
}