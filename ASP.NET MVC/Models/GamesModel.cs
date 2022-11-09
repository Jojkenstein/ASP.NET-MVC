namespace ASP.NET_MVC.Models
{
    public class GamesModel
    {
        public static string EvalGuess(int guessNr, int randNr)
        {
            //++Cookie

            if (guessNr > randNr)
            {
                
                return "Lower!";
            }
            else if (guessNr < randNr)
            {
                
                return "Higher!";
            }
            else
            {
                return "Correct!";
            }
        }
        public static string RandGen()
        {
            Random rand = new Random();
            return rand.Next(1, 101).ToString();
        }
    }
}
