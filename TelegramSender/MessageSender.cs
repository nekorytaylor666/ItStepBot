using AppCoreModels;
using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;

namespace TelegramSender
{
    public class MessageSender
    {
        private static TelegramBotClient bot;
        public MessageSender()
        {
            bot = Bot.GetBot();
        }

        public async void SendMessageToList(List<UserModel> users, string message)
        {
            foreach (var user in users)
            {
                try
                {
               
                    await bot.SendTextMessageAsync(user.ChatId, message);
                    Console.WriteLine("Сообщение отправлено "+user.ChatId + user.Name);
                
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message + user.ChatId + user.Name);
                }
            }
        }
    }
}
