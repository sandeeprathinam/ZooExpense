using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZooExpense.ManagerServices.PriceManager;
using ZooExpense.Models;

namespace ZooExpense.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPriceManager priceManager;
        public HomeController(ILogger<HomeController> logger, IPriceManager priceManager)
        {
            _logger = logger;
            this.priceManager = priceManager;
            
        }

        public IActionResult Index()
        {
            ExpensesViewModel expensesViewModel = new ExpensesViewModel();
            expensesViewModel = priceManager.CalculateExpense(expensesViewModel);
            return View(expensesViewModel);
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
