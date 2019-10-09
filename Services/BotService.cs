using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                BotDomain.Add(bot.BotToken, bot.BotDomain);
            }
        }

        public Dictionary<string, TelegramBotClient> Client { get; } = new Dictionary<string, TelegramBotClient>();
        public Dictionary<string, Guid> BotDomain { get; } = new Dictionary<string, Guid>();
    }
}
