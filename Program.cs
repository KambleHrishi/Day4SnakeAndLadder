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

            int position = 0;

            Random random = new Random();

            int diceCount = 0;
            Dictionary<int, int> dictionary = new Dictionary<int, int>(); //to report number of times the die was cast and the value of that instance

            while (position < WINNING_POSITION)
            {

                int dice = random.Next(1, 7);
                diceCount++;  // Number of times the die was cast


                int checkOption = random.Next(1, 4);
                int previousPosition = position;

                Console.WriteLine("========================================================================================================================");
                Console.WriteLine("Check option : " + checkOption + "");
                Console.WriteLine("Dice value : " + dice);
                switch (checkOption)
                {
                    case NO_PLAY:
                        //NO MOVE NEEDED
                        break;
                    case LADDER:
                        position += dice;
                        break;
                    case SNAKE_BITE:
                        position -= dice;
                        break;
                    default:
                        //position = 0; Do Nothing
                        break;
                }

                Console.WriteLine("Postion of player is :" + position);

                if (position > 100)
                {
                    position = previousPosition;
                    Console.WriteLine("PLAYER STAYS IN SAME POSITION: " + position);

                }
                else if (position == WINNING_POSITION)
                {
                    Console.WriteLine("Player Won as position is : " + position);

                }
                else if (position < 0)
                {
                    position = 0;
                }
                dictionary[diceCount] = position; // add to dictionary report 
            }

            Console.WriteLine("Report of number of times the dice was cast to win the game and the position after every die role");
            Console.WriteLine("Dice Count : Dice Position");

            foreach (KeyValuePair<int, int> pair in dictionary)
            {
                Console.WriteLine("         {0} : {1}", pair.Key, pair.Value); // show's in tabular form

            }

            Console.WriteLine("Total number if times the dice cast was for winning : " + diceCount);

        }
    }
}