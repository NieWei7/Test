using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFTest.Models;

namespace EFTest.Controllers
{
    public class HomeController : Controller
    {
        private WeChatContext _context;
        public HomeController(WeChatContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var add = _context.UserInfo.Add(new UserInfo
                { UserLoginName = "tc", PassWord = "123X", Age = 17, Sex = "女", UserName = "tiancai" });
            _context.SaveChanges();
            

            //var list = _context.UserInfo.ToList();
            var db = _context.UserInfo.Find(3);
            //var table = _context.UserInfo.FirstOrDefault(x => x.Id == 2);
            //ViewBag.a = db;
            //ViewBag.b = table;
            return View(db);
        }
    }
}
