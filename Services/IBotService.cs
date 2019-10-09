using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NokilayBot.Services
{
    public interface IBotService
    {
        Dictionary<string, TelegramBotClient> Client { get; }
        Dictionary<string, Guid> BotDomain { get; }
    }
}
