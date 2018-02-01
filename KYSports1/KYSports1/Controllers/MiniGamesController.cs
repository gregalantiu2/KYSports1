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
            BingoList model = new BingoList();
            Repo repo = new Repo();
            model.List = repo.GetBingoText();
            return View(model);
        }
    }
}