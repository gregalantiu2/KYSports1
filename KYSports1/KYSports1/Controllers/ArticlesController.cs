using KYSports1.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KYSports1.Controllers
{
    public class ArticlesController : ApiController
    {
        private Repo _repo = new Repo();

        // DELETE api/<controller>/5
        [Route("articles/delete/{articleID}")]
        [AcceptVerbs("DELETE")]
        [Authorize(Roles = "admin")]
        public IHttpActionResult Delete(int articleID)
        {
            _repo.DeleteArticle(articleID);
            ArticleListAdmin model = new ArticleListAdmin();
            model.List = _repo.GetAllArticles();

            return Ok(model);
        }
    }
}