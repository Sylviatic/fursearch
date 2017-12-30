using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace FurSearch.Modules
{
    public class TextCommands : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task HelloCMD()
        {
            await ReplyAsync("Hello World!");
        }
    }
}
