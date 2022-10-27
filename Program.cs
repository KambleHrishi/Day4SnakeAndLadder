namespace Day4SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[]args)
        {
            //int Position = 0;
            //Console.WriteLine("Player is at Starting Position: " + Position);

            int player1 = 0;

            Random random = new Random(); //to generate random numbers

            player1 = random.Next(1, 7); //to print randomly 1-6
            Console.WriteLine(player1);

        }
    }
}