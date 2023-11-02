using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using webUi.Extensions;
using webUi.Models;
using static webUi.Program;
namespace webUi.Controllers
{

    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Error404()
        {
            return View();
        } 
        public PartialViewResult navbar()
        {
            return PartialView();
        }
        public PartialViewResult footer()
        {
            return PartialView();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Referances()
        {
            return View();
        }
        public IActionResult Kurumsal()
        {
            return View();
        }

       
        
        
        
            

    }


}