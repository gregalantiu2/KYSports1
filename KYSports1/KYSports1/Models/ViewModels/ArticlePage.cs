using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYSports1.Models.ViewModels
{
    public class ArticlePage
    {
        public Articles articles { get; set; }
        public List<Articles> list { get; set; }
        public List<Articles> clist { get; set; }
        public List<BingoText> bingo { get; set; }
        public PlayerQueryString pstring { get; set; }
        public CreateArticle create { get; set; }
        public SelectList categories1 { get; set; }
        public ArticleListAdmin admin { get; set; }
        public LoginViewModel login { get; set; }
        public List<PlayerNames> plist { get; set; }
        public PlayerNames playernames { get; set; }
    }
}