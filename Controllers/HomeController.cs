using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Sinhvien5tot.Models;


namespace Sinhvien5tot.Controllers
{
    public class HomeController : Controller
    {
        private AccountEntity db = new AccountEntity();

        public ActionResult Index()
        {
            //return View();
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Dangnhap");
            }
        }

        public ActionResult Dangnhap()
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


    }
}