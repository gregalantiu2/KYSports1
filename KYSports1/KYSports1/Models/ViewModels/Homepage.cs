using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KYSports1.Models.ViewModels
{
    public class Homepage
    {
        public GameDetails gameDetails { get; set; }
        public List<Articles> articles { get; set; }
        public List<Articles> navbar { get; set; }

    }
}