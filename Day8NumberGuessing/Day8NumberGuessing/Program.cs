namespace NumberGuessing;

class Program
{
    public static void Main(string[] args)
    {
        Random number = new Random();

        int isCorrect = number.Next(0,100);

        bool win = false;

        do
        {
            Console.WriteLine("Guess a number between 1 and 100: ");
            string userInput = Console.ReadLine();

            int i = int.Parse(userInput);

            if (i > isCorrect)
            {
                Console.WriteLine("That is too high! Guess again.");
            }
            else if (i < isCorrect)
            {
                Console.WriteLine("That is too low! Guess again.");
            }
            else if (i == isCorrect)
            {
                Console.WriteLine("That is correct, You Win!");
                win = true;
            }

        } while (win == false);
    }
}