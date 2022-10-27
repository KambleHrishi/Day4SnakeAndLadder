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

            while (position <= 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);  // to generate randomly 1-6 dice roll
                int checkOption = random.Next(1, 4); //  to generate randomly options
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



                if (position <= 0)
                {
                    Console.WriteLine("Player restarts from 0");
                }
                else
                {
                    Console.WriteLine("Player stays in same postion");
                }
                break;
            }

        }
    }
}