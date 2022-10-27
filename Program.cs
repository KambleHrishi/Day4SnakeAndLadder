namespace Day4SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[]args)
        {
            const int NO_PLAY = 1,
                       LADDER = 2,
                   SNAKE_BITE = 3,
             WINNING_POSITION = 100;

            int diceCount = 0;

            Dictionary<int, int> dictionary = new(); //to report number of times the die was cast and the value of that instance

            string getPlayerString(bool sign)
            {
                return sign ? "One" : "Two";
            }

            int winningLogic(int position, bool playerSign)
            {
                string player = getPlayerString(playerSign);

                Random random = new();
                int dice = random.Next(1, 7);
                diceCount++;  // Number of times the die was cast


                int checkOption = random.Next(1, 4);
                int previousPosition = position;

                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("Player position : " + position);
                Console.WriteLine("Check option : " + checkOption);
                Console.WriteLine("Dice value : " + dice);
                switch (checkOption)
                {
                    case NO_PLAY:
                        //NO MOVE NEEDED
                        break;
                    case LADDER:
                        position += dice;
                        winningLogic(position, playerSign);
                        break;
                    case SNAKE_BITE:
                        position -= dice;
                        break;
                    default:
                        //position = 0; Do Nothing
                        break;
                }

                if (position > WINNING_POSITION)
                {
                    position = previousPosition;
                    Console.WriteLine("PLAYER " + player + " STAYS IN SAME POSITION : " + position);
                }
                else if (position == WINNING_POSITION)
                {
                    dictionary[diceCount] = position; // add to dictionary report 
                    return position;
                }
                else if (position < 0)
                {
                    position = 0;
                    Console.WriteLine("PLAYER " + player + " STARTS AGAIN FROM POSITION : " + position);
                }
                dictionary[diceCount] = position; // add to dictionary report 

                return position;
            }

            void viewReport(bool winnerFlag)
            {
                string player = getPlayerString(winnerFlag);

                Console.WriteLine("Report of number of times the dice was cast to win the game and the position after every die role");
                Console.WriteLine("Dice Count : Dice Position");

                foreach (KeyValuePair<int, int> pair in dictionary)
                {
                    Console.WriteLine("         {0} : {1}", pair.Key, pair.Value); // show's in tabular form

                }
                Console.WriteLine("\n****************");

                Console.WriteLine("*Player " + player + " Won*");
                Console.WriteLine("****************");
                Console.WriteLine("\nTotal number of times the dice cast was for winning : " + diceCount);
            }

            void play()
            {
                int playerOnePos = 0, playerTwoPos = 0;
                bool winnerFlag = false; //set true if player one wins, false if player two wins

                while (playerOnePos < WINNING_POSITION || playerTwoPos < WINNING_POSITION)
                {
                    playerOnePos = winningLogic(playerOnePos, true);

                    if (playerOnePos == WINNING_POSITION)
                    {
                        winnerFlag = true;
                        break;
                    }

                    playerTwoPos = winningLogic(playerTwoPos, false);

                    if (playerTwoPos == WINNING_POSITION)
                    {
                        winnerFlag = false;
                        break;
                    }
                }
                viewReport(winnerFlag); // IF REPORT NOT NEEDED COMMENT THE FOLLWOING LINE
            }

            play(); //GAME STARTS HERE

        }
    }
}