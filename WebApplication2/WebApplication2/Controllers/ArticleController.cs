using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
			List<Article> articls = new List<Article>()
			{
				new Article(){ Id = 1, Title ="FirstTitle", date = new DateTime(), Comment="First Article Comment", Text = "Text of first article" },
				new Article(){ Id = 2, Title ="SecondTitle", date = new DateTime(), Comment="Second Article Comment", Text = "Text of Second article" }
			};

            return View(articls);
        }
    }
}