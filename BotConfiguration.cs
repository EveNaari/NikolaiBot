using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NokilayBot
{
    public class BotConfiguration
    {
        public List<BotInfo> BotInfo { get; set; }
    }

    public class BotInfo
    {
        public string BotToken { get; set; }
    }
}

