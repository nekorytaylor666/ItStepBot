using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsumeApi.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using ConsumeApi.Utility;
using ConsumeApi.Factory;
using AppCoreModels;
using TelegramSender;

namespace ConsumeApi.Controllers
{
    public class HomeController : Controller
    {
        
        public async Task<IActionResult> index()
        {
            
            return View();
        }

        
    }
}
