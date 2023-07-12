namespace If_statement_challenge_2
{
    internal class Program
    {
        private static int score = 0;
        private static int highscore = 0;
        private static string highscorePlayer = "";

        static void CheckScore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("New highscore holder is " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer);
            }
        }

        static void Main(string[] args)
        {
            CheckScore(100, "Alice");
            CheckScore(75, "Bob");
            CheckScore(150, "Charlie");
            CheckScore(50, "David");

            Console.Read();
        }
    }
}
