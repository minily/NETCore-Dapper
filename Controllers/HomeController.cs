using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DapperDemo.Models;
using DapperDemo.DapperService;
using System.Data;
using DapperDemo.Services;

namespace DapperDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IOilFillTypeService _oilFillTypeService;

        public HomeController(ILogger<HomeController> logger, IOilFillTypeService oilFillTypeService)
        {
            _oilFillTypeService = oilFillTypeService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sql = "select * from oil_filltype";
            var list = DbContext.Query<oil_filltype>(sql).ToList();

            var list2 = _oilFillTypeService.List();
            
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
