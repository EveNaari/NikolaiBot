using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace NokilayBot.Services
{
    public class BotService : IBotService
    {
        //private readonly BotConfiguration _config;

        public BotService(IOptions<BotConfiguration> config)
        {
            BotConfiguration _config = config.Value;
            foreach (var bot in _config.BotInfo)
            {
                Client.Add(bot.BotToken, new TelegramBotClient(bot.BotToken));
            }
        }

        public Dictionary<string, TelegramBotClient> Client { get; } = new Dictionary<string, TelegramBotClient>();
    }
}
