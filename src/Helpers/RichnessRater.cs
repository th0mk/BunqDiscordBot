namespace Bot.Helpers
{
    public class RichnessRater
    {
        public string GetRichnessJudgement(double amount)
        {
            if (amount > 1000)
            {
                return "So ey, hij is echt knetter rijk!";
            }
            else if (amount > 500)
            {
                return "Daar moet hij wel even mee vooruit kunnen, toch? Ja?";
            }
            else if (amount > 350)
            {
                return "Hm, tsja, dit is wel genoeg denk ik.";
            }
            else if (amount > 200)
            {
                return "Hij moet nu wel gaan oppassen. Dit is niet zo veel meer....";
            }
            else if (amount > 100)
            {
                return "Ik denk dat hij maar moet stoppen met zo veel thuisbezorgd bestellen nu.";
            }
            else if (amount > 70)
            {
                return "Amai, das niet veel.";
            }
            else if (amount > 40)
            {
                return "Hij leeft nu op water en brood. Dit is simpelweg te weinig geld.";
            }

            return "Oei, dit zijn de allerlaatste centen. Wens hem sterkte.";
        }
    }
}
