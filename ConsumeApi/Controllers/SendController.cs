using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumeApi.Factory;
using ConsumeApi.Models;
using ConsumeApi.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TelegramSender;

namespace ConsumeApi.Controllers
{
    public class SendController : Controller
    {
        private readonly IOptions<MySettingModel> appSetting;

        public SendController(IOptions<MySettingModel> app)
        {
            appSetting = app;
            ApplicationSettings.WebApiUrl = appSetting.Value.WebApiBaseUrl;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            

            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Index(string message, string group)
        {
            var Group = await ApiClientFactory.instance.GetGroup(group);
            MessageSender sender = new MessageSender();

            sender.SendMessageToList(Group, message);
            return View();
        }
    }
}