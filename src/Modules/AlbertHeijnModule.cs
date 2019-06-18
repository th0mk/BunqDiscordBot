using System.Linq;
using System.Threading.Tasks;
using Bot.Models;
using Discord;
using Discord.Commands;
using RestSharp;

namespace Bot.Modules
{
    [Name("AlbertHeijn")]
    public class MathModule : ModuleBase<SocketCommandContext>
    {
        [Command("frikandelbroodje")]
        public async Task FrikandelBroodje()
        {
            var client = new RestClient("https://www.ah.nl/service/rest/delegate?url=/producten/product/wi230720/ah-frikandelbroodje");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var parsedResponse = AlbertHeijn.FromJson(response.Content);

            await ReplyAsync($"Een frikandelbroodje is op dit moment €{AlbertHeijn.GetPrice(parsedResponse)}!");
        }

        [Command("redbull")]
        [Alias("bull")]
        public async Task RedBull()
        {
            var client = new RestClient("https://www.ah.nl/service/rest/delegate?url=/producten/product/wi67881/red-bull-regular-4-pack");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var parsedResponse = AlbertHeijn.FromJson(response.Content);

            await ReplyAsync($"Een 4-pack Redbull is op dit moment €{AlbertHeijn.GetPrice(parsedResponse)}!");
        }

        [Command("euroshopperenergy")]
        [Alias("energy", "euroshopper", "vmbo")]
        public async Task Euroshopper()
        {
            var client = new RestClient("https://www.ah.nl/service/rest/delegate?url=/producten/product/wi194172/ah-basic-energy-drink");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var parsedResponse = AlbertHeijn.FromJson(response.Content);

            await ReplyAsync($"Een AH Basic Energy is op dit moment €{AlbertHeijn.GetPrice(parsedResponse)}!");
        }
    }
}
