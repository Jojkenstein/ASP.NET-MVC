namespace ASP.NET_MVC.Models
{
    public class GamesModel
    {
        public static bool guessCorr = false;
        public static int guessCnt;
        public List<string> highScore = new List<string>();
        public static string EvalGuess(int guessNr, int randNr) //removed "static" for guessCorr to be able to be set
        {
            //++Cookie (sedan glöm ej att ta hand om felet som uppstår när man klickar submit med tom ruta)

            if (guessNr > randNr)
            {

                return $"Lower! (guessNr = {guessNr}, randNr = {randNr}, guessCorr = {GamesModel.guessCorr})";
            }
            else if (guessNr < randNr)
            {

                return $"Higher! (guessNr = {guessNr}, randNr = {randNr}, guessCorr = {GamesModel.guessCorr})";
            }
            else
            {
                GamesModel.guessCorr = true;
                return $"Correct! (guessNr = {guessNr}, randNr = {randNr}, guessCorr = {GamesModel.guessCorr})";
            }
        }
        public static string RandGen()
        {
            Random rand = new Random();
            return rand.Next(1, 101).ToString();
        }
        public static string HighScoreJoined()
        {
            highScore.Add(GamesModel.guessCnt.ToString() + " - " + DateTime.Now.ToString("yyyy-MM-dd:G"));
            highScore.Sort();
            //return String.Join(",", highScore);
            return String.Join("<BR>", highScore);
        }
    }
}
