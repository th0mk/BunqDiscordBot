using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bot.Configurations;
using Bot.Models;
using Bot.Structs;
using Discord.Commands;
using RestSharp;

namespace Bot.Modules
{
    [Name("CoronaTest")]
    public class CoronaTestModule : ModuleBase<SocketCommandContext>
    {
        [Command("result")]
        [Alias("uitslag")]
        public async Task TestResult()
        {
            var client = new RestClient("https://user-api.coronatest.nl/uitslagen/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", TokenConfiguration.Config.CoronaTestBearerToken);

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                await ReplyAsync("Server gaf 401");
                return;
            }

            var parsedResponse = CoronaResults.FromJson(response.Content);

            var result = parsedResponse.FirstOrDefault();
            if (result == null)
            {
                await ReplyAsync("Kreeg geen resultaten binnen manbro, misschien is de bearer token verlopen");
                return;
            }

            if (result.Resultaat == "ONBEKEND")
            {
                await ReplyAsync($"Resultaat van je test op {result.Afnamedatum.ToShortDateString()} is nog onbekend.");
                return;
            }

            await ReplyAsync($"Uitslag is binnen: {result.Resultaat}");
        }


        [Command("uitslagmonitor")]
        public async Task MonitorTestResult()
        {
            var client = new RestClient("https://user-api.coronatest.nl/uitslagen/");
            var request = new RestRequest(Method.GET);
            request.AddHeader("authorization", TokenConfiguration.Config.CoronaTestBearerToken);

            var differentResult = false;

            while (!differentResult)
            {
                var response = client.Execute(request);

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    await ReplyAsync("Server gaf 401");
                    return;
                }

                var parsedResponse = CoronaResults.FromJson(response.Content);

                if (parsedResponse.FirstOrDefault().Resultaat == "ONBEKEND")
                {
                    Console.WriteLine("Nog niks");
                    break;
                }

                await ReplyAsync($"Uitslag is binnen: {result.Resultaat}");
            }
            
            
        }
    }
}
