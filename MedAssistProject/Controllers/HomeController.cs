using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Logging;
using MedAssistProject.Models;

namespace MedAssistProject.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Index(Account Ac)
        {
            if (ModelState.IsValid)
            {
                string constr = ConfigurationManager.AppSettings["mongodb+srv://admin:dmAVai2F7TGiKDKZ@cluster0.ajdwt.mongodb.net/test"];
                var Client = new MongoClient(constr);
                var DB = Client.GetDatabase("Acc");
                var collection = DB.GetCollection<Account>("Account");
                collection.InsertOneAsync(Ac);
                return RedirectToAction("Patient");
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MedReader()
        {
            return View();
        }

        public IActionResult MedRecorder()
        {
            return View();
        }

        public IActionResult MedAdvisor()
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
