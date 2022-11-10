namespace ASP.NET_MVC.Models
{
    public class GamesModel
    {
        public static bool guessCorr = false;
        public static int guessCnt;
        public List<string> highScore = new List<string>();
        public static string EvalGuess(int guessNr, int randNr) //removed "static" for guessCorr to be able to be set
        {
            if (guessNr > randNr)
            {
                return $"{guessNr} is too high.";
            }
            else if (guessNr < randNr)
            {
                return $"{guessNr} is too low.";
            }
            else
            {
                GamesModel.guessCorr = true;
                return $"{guessNr} is correct!";
            }
        }
        public static string RandGen()
        {
            Random rand = new Random();
            return rand.Next(1, 101).ToString();
        }
    }
}
