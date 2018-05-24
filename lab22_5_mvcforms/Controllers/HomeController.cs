using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab22_5_mvcforms.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login(string _username, string _color,
        string _listen, string _font)
        {
            ViewBag.Username = _username;
            ViewBag.Color = _color;
            ViewBag.Listen = _listen;
            ViewBag.Font = _font;


            Session["Username"] = _username;
            Session["Color"] = _color;
            Session["Listen"] = _listen;
            Session["Font"] = _font;
            return View();
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your Welcome page.";

            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View();
        }
    }
}