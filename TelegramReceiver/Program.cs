using System;
using Telegram.Bot;
using CoreAppClient;
using ConsumeApi.Factory;
using AppCoreModels;

namespace TelegramReceiver
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("717435055:AAFc_W3cyGcoo90k63STovpMkzRDRV4n38Q");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private async static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type != Telegram.Bot.Types.Enums.MessageType.Text) return;
                Console.WriteLine(e.Message.Text);
            switch (e.Message.Text.ToLower())
            {
                case "/start":
                    
                    break;
                case "/how are you ?":
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Fine, thank you, and you ?");
                    break;
                case "/hi":
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Hello " + e.Message.Chat.Id);
                    break;
                case "/good morning":
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Good Morning " + e.Message.Chat.Username);
                    break;
                default:
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Usage: 
                        /How are you ?
                        /Good Morning 
                    ");
                    break;
            }
        }
    }
}
