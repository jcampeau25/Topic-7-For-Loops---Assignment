namespace Topic_7_For_Loops___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Countdown
            for (int i = 10; i >= 1; i = i - 1)
                Console.WriteLine(i);
            Console.WriteLine("Blastoff!");
            Console.WriteLine();

            //// X and Y
            int y;
            Console.WriteLine("X" + "\t" + "Y");
            Console.WriteLine("------------------");
            for (int x = -10; x <= 10; x = x + 2)
            {
                y = x * x;
                Console.WriteLine(x + "\t" + y);

            }
            Console.WriteLine();

            // Name Repeater
            Console.WriteLine("Please enter your name");
            int n = 1;
            string name = Console.ReadLine();
            Console.WriteLine();
            if (name.ToLower() == "aldworth")
                n = 6;
            for (n = n; n <= 10; n = n + 1)
                Console.WriteLine(name);




        }


        }
    }

