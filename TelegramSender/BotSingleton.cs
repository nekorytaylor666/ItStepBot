using System;
using Telegram.Bot;
namespace TelegramSender
{
    public class Bot
    {
        private static TelegramBotClient bot;

        private Bot()
        {

        }
        
        public static TelegramBotClient GetBot()
        {
            if(bot == null)
            {
                bot = new TelegramBotClient("723184102:AAGvHsIt5gVJMoqEeiNGS07VMS_3UQeUnW0");
            }
            return bot;
        }
    }
}
