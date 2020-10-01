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
    public class DangkyController : Controller
    {
        // GET: Dangky

        private AccountEntity db = new AccountEntity();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TaoTaikhoan()
        {
            return View();
        }

        //POST: Account/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TaoTaikhoan([Bind(Include = "Id,Username,Password,Hoten,GioiTinh,NgaySinh,Lop,Khoa,MaSoSinhVien,Vien,Email,SoDT,SecurityString,Quyen")] Account account)
        {
            account.Quyen = "NewMember";
            account.SecurityString = account.Username + account.Hoten.Substring(0, 2) + account.Password;
            account.Password = GetMD5(account.SecurityString);

            if (ModelState.IsValid)
            {
                db.User.Add(account);
                db.SaveChanges();
                // return RedirectToAction("Chitiet", "Dangky", new { id = account.Id });
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}