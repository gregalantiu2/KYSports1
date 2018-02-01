using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KYSports1.Models.ViewModels
{
    public class CreateArticle
    {
        public Articles article { get; set; }
        public SelectList categories { get; set; }
    }
}