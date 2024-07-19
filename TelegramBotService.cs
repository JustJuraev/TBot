using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace Tbot
{
    public class TelegramBotService
    {
        private static TelegramBotClient client;
        private readonly string _connectionString;
     
        private static string _chatId;

        public TelegramBotService(string chatId, string token)
        {
            
            _chatId = chatId;
            client = new TelegramBotClient(token);
         
        }

   
        public void SendMessageAsync(string message)
        {
            try
            {
                client.SendTextMessageAsync(_chatId, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    
    }

    
}
