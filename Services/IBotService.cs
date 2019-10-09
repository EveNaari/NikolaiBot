using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace NokilayBot.Services
{
    public interface IBotService
    {
        Dictionary<string, TelegramBotClient> Client { get; }
    }
}
