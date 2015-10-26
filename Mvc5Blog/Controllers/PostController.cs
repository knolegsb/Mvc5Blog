using Mvc5Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5Blog.Controllers
{
    public class PostController : Controller
    {
        private Mvc5BlogModel model = new Mvc5BlogModel();
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Update(int? id, string title, string body, DateTime dateTime, string tags)
        {
            if(!IsAdmin)
            {
                return RedirectToAction("Index");
            }

            Post post = GetPost(id);

            return null;
        }

        private Post GetPost(int? id)
        {
            throw new NotImplementedException();
        }

        public bool IsAdmin { get { return true; /*return Session["IsAdmin"] != null && (bool)Session["IsAdmin"]; */} }
    }
}