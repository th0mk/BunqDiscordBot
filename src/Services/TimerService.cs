using System;
using System.Net;
using System.Threading;
using Bot.Configurations;
using RestSharp;

namespace Bot.Services
{
    public class TimerService
    {
        private readonly Timer _coronaTokenTimer;

        public TimerService()
        {
            // Loop zodat bearer token niet expired
            this._coronaTokenTimer = new Timer(_ =>
                {
                    Console.WriteLine("Calling bearer token");

                    var client = new RestClient("https://user-api.coronatest.nl/uitslagen/");
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("authorization", TokenConfiguration.Config.CoronaTestBearerToken);
                    var response = client.Execute(request);

                    Console.WriteLine(response.StatusCode == HttpStatusCode.Unauthorized
                        ? "Unauthorized!"
                        : $"Success");
                },
                null,
                TimeSpan.FromSeconds(5),
                TimeSpan.FromMinutes(12));
        }
    }
}