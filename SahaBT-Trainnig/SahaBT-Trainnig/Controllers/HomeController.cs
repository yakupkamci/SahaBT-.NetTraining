using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SahaBT_Trainnig.Data;
using SahaBT_Trainnig.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SahaBT_Trainnig.Controllers
{
    public class HomeController : Controller
    {
        Response response = new Response();

        public IActionResult Index()
        {            
            return View(response.Answer1());
        }
        
        
        public IActionResult Gender(int id)
        {
            if (response.Answer2(id) != null) return View(response.Answer2(id));
            else return RedirectToAction("Error");
            
        }

        public IActionResult Country(int id)
        {
            if (response.Answer3(id) != null) return View(response.Answer3(id));
            else return RedirectToAction("Error");
        }

        public IActionResult Error()
        {   
            return View();
        }
    }
}
