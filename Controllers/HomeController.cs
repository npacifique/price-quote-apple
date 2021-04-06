using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteApp.Models;

namespace QuoteApp.Controllers
{
    public class HomeController : Controller
    {
 
       public HomeController()
        {
            
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Quote());
        }

        [HttpPost]
        public IActionResult Edit(Quote model)
        {
            if(!ModelState.IsValid) {
                return View("Edit",  model);
            }

            return View("Edit", new Quote() 
            { 
                Total = model.Total, 
                Discount = model.Discount     
            });
        }



       
        
    }
}
