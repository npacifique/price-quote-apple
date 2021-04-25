using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteApp.Models;
using QuoteApp.ModelView;

namespace QuoteApp.Controllers
{
    public class HomeController : Controller
    {


       public HomeController(){
            
       }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new QuoteModelView();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(QuoteModelView model)
        {
            if(!ModelState.IsValid) {
                return View("Edit",  model);
            }

            return View("Edit", new QuoteModelView()
            {
                Quote = new Quote()
                {
                    Discount = model.Discount.Value,
                    Total = model.Total.Value
                }    
            });
        }



       
        
    }
}
