using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoesE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ShoesE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DBCT Context { get; }
        public HomeController(ILogger<HomeController> logger, DBCT _context)
        {
            _logger = logger;
            this.Context = _context;
        }
     
        public IActionResult Index()
        {
            List<Sanpham> sanphams = (from Sanpham in this.Context.SANPHAM.Take(10)
                                        select Sanpham).ToList();
            return View(sanphams);
        }
        public IActionResult Shopnow()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
