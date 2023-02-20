using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MedAssistProject.Models;

namespace MedAssistProject.Controllers
{
    public class LabTestController : Controller
    {

        public IActionResult CBC()
        {

            return PartialView("_CBC");
        }

        public IActionResult LoadForm(string formName){
            return PartialView($"_{formName}");

        }

    }    
}