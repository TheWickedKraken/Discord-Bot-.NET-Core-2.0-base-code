﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace DiscordBot.NETCore2._0
{
    public class Commands : ModuleBase
    {
        [Command("Hello")] //Command
        [Summary("Says Ello!!")] //Description
        [Alias("Hi")] //Other uses for this command
        public async Task Hello() //Remainder come after the command itself
        {
                await Context.Channel.SendMessageAsync("Ello!!");
        }
    }
}
