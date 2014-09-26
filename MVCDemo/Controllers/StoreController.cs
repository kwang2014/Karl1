using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            ViewBag.Message = "Hello from Store.Index()";
            return View();
        }

        public ActionResult Browse(string genre)
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title = "Product: " + i });
            }

            return View(albums);
        }

        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }
    }
}
