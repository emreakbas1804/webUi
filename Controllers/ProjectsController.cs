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

    public class ProjectsController : Controller
    {
        

        public IActionResult Adana1()
        {
            return View();
        } 
        public IActionResult Adana2()
        {
            return View();
        } 
        public IActionResult Aydin()
        {
            return View();
        } 
        public IActionResult Andritz()
        {
            return View();
        }
        
        
        
        
            

    }


}