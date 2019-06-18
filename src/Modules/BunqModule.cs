using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Bot.Configurations;
using Bot.Models;
using Bunq.Sdk.Context;
using Bunq.Sdk.Model.Generated.Endpoint;
using Discord.Commands;
using RestSharp;

namespace Bot.Modules
{
    [Name("Bunq")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class BunqModule : ModuleBase<SocketCommandContext>
    {
        [Command("balance")]
        public async Task Balance()
        {
            Console.WriteLine("Balance started");
            var allMonetaryAccounts = MonetaryAccountBank.List().Value;

            var mainMonetaryAccount = allMonetaryAccounts.FirstOrDefault(f => f.Description == TokenConfiguration.Config.MainMonetaryAccountName);

            var now = DateTime.Now;
            var paydayDayOfMonth = TokenConfiguration.Config.PaydayDayOfMonth;
            var payday = now.Day > paydayDayOfMonth
                ? new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, paydayDayOfMonth)
                : new DateTime(now.Year, now.Month, paydayDayOfMonth);
            var daysLeft = (payday - now).Days;

            var client = new RestClient("https://www.ah.nl/service/rest/delegate?url=/producten/product/wi230720/ah-frikandelbroodje");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var parsedResponse = AlbertHeijn.FromJson(response.Content);
            var frikandelBroodjePrice = AlbertHeijn.GetPrice(parsedResponse);

            if (frikandelBroodjePrice == null)
            {
                await ReplyAsync($"AH API kapot.");
                return;
            }

            var amountOfFrikandelBroodjes = (double.Parse(mainMonetaryAccount?.Balance.Value, CultureInfo.InvariantCulture) / frikandelBroodjePrice.Value).ToString("0");

            Console.WriteLine("Replying..");

            await ReplyAsync($"Thom zijn budget voor deze maand is €{mainMonetaryAccount?.Balance.Value}. Dat is weinig! \n" +
                             $"Hier kan hij {amountOfFrikandelBroodjes} frikandelbroodjes mee kopen met de huidige prijs van €{frikandelBroodjePrice}.\n" +
                             $"Over {daysLeft} dagen komt er weer een hoop geld bij.");

            Console.WriteLine("Balance executed");
        }

        [Command("plex")]
        public async Task Plex()
        {
            var savingGoals = MonetaryAccountSavings.List().Value;

            var plexSavingGoal = savingGoals.FirstOrDefault(f => f.Description == "HDD");

            await ReplyAsync($"Plex zit op €{plexSavingGoal.Balance.Value}. Dat is al op {plexSavingGoal.SavingsGoalProgress}% van het doel van €{plexSavingGoal.SavingsGoal}");
        }
    }
}
