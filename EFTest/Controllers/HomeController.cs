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
            var list = _context.UserInfo.ToList();
            return View(list);
        }
    }
}
