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

        public async Task<IActionResult> Index()
        {
            var group = await ApiClientFactory.instance.GetGroup("SEP-172");
            MessageSender sender = new MessageSender();

            sender.SendMessageToList(group, "Тест");

            return View();
        }

        public async Task<IActionResult> SendMessage()
        {
            
            return View();
        }
    }
}