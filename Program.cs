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
            Random random = new Random();
            int dice = random.Next(1, 7),       //to generate 1-6 randomly by rolling dice
                checkOption = random.Next(1, 4);//to generate random option from NO_PLAY, LADDER, SNAKE_BITE 

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

        }
    }
}