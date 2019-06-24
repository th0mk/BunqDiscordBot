using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Bot.Configurations;
using Bot.Helpers;
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
        readonly RichnessRater _richnessRater = new RichnessRater();

        [Command("balance")]
        [Alias("budget")]
        public async Task Balance()
        {
            var allMonetaryAccounts = MonetaryAccountBank.List().Value;

            var mainMonetaryAccount = allMonetaryAccounts.FirstOrDefault(f => f.Description == TokenConfiguration.Config.MainMonetaryAccountName);

            var now = DateTime.Now;
            var paydayDayOfMonth = TokenConfiguration.Config.PaydayDayOfMonth;
            var payday = now.Day > paydayDayOfMonth
                ? new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, paydayDayOfMonth)
                : new DateTime(now.Year, now.Month, paydayDayOfMonth);
            var daysLeft = (payday - now).Days + 1;

            var client = new RestClient("https://www.ah.nl/service/rest/delegate?url=/producten/product/wi230720/ah-frikandelbroodje");
            var request = new RestRequest(Method.GET);
            var response = client.Execute(request);

            var parsedResponse = AlbertHeijn.FromJson(response.Content);
            var frikandelBroodjePrice = AlbertHeijn.GetPrice(parsedResponse);

            if (frikandelBroodjePrice == null)
            {
                await ReplyAsync("AH API kapot.");
                return;
            }

            var budget = double.Parse(mainMonetaryAccount?.Balance.Value, CultureInfo.InvariantCulture);
            var amountOfFrikandelBroodjes = (double.Parse(mainMonetaryAccount?.Balance.Value, CultureInfo.InvariantCulture) / frikandelBroodjePrice.Value).ToString("0");

            await ReplyAsync($"{TokenConfiguration.Config.Name} zijn budget voor deze maand is €{budget}. {_richnessRater.GetRichnessJudgement(budget)} \n" +
                             $"Hier kan hij {amountOfFrikandelBroodjes} frikandelbroodjes mee kopen met de huidige prijs van €{frikandelBroodjePrice}.\n" +
                             $"Over {daysLeft} " + (daysLeft == 1 ? "dag" : "dagen") + " komt er weer een hoop geld bij.");

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
