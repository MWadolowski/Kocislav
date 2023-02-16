using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace Kocislav.Discord
{
    public class CattoModule : ModuleBase<SocketCommandContext>
    {
        [Command("kurwa")]
        public async Task MakeSound()
        {
            var random = new Random().NextDouble();
            Console.WriteLine(random);
            if (random > 0.65)
            {
                await Context.Channel.SendMessageAsync("Miau");
            }
            else
            {
                await Context.Channel.SendMessageAsync("https://tenor.com/view/cat-cat-running-away-ahowey-idk-man-wtf-cat-gif-22522951");
            }
        }
    }
}
