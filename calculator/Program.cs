using System;

namespace calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            Int32 Number1;
            Int32 Number2;
            Int32 Final = 0;
            string choice;

            Console.WriteLine("wtlcome to my calculator");
            Console.Write("enter the first number");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("What to do with them? Write down the character \"*, /, -, +\" ");
            choice = Console.ReadLine();

            if (choice == "+")
            {
                Final = Number1 + Number2;
            }
            if (choice == "-")
            {
                Final = Number1 - Number2;
            }
            if (choice == "*")
            {
                Final = Number1 * Number2;
            }
            if (choice == "/")
            {
                Final = Number1 / Number2;
            }
          
            Console.Write("The ending result is {0}",Final );
        }
    }
}
