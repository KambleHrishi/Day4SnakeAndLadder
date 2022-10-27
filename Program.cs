namespace Day4SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[]args)
        {
            const int NO_PLAY = 1,
                       LADDER = 2,
                   SNAKE_BITE = 3;
            int position = 0;

            while (position < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7),
                   checkOption = random.Next(1, 4),
                   previousPosition = position;
                switch (checkOption)
                {
                    case NO_PLAY:
                        position = 0;
                        break;
                    case LADDER:
                        position = position + dice;
                        break;
                    case SNAKE_BITE:
                        position = position - dice;
                        break;

                    default:
                        position = 0;
                        break;
                }
                Console.WriteLine("postion of player is :" + position);

                if (position > 100)
                {
                    position = previousPosition;
                    Console.WriteLine("PLAYER STAYS IN SAME POSITION: " + position);
                }
                else
                {
                    position = 100;
                }
                break;
            }

        }
    }
}