using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KYSports1.Models
{
    public class Articles
    {
        public int ArticleID { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public string PublisedString
        {
            get
            {
                return Published.ToString("MM-dd-yyyy");
            }
            set
            {
                Published.ToString("MM-dd-yyyy");
            }
        }
        public string ArticleBody { get; set; }
        public int CategoryID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public bool CarFlg { get; set; }
        public string Category { get; set; }
        public string PageURL { get; set; }
        public string Description { get; set; }
    }
}