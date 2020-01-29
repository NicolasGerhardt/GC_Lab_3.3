using System;
using System.Text.RegularExpressions;

namespace GC_LAB_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the backwardizer");
            Console.WriteLine();

            do
            {
            string userInput = GetValidatedUserInput();

            string[] words = userInput.Split(" ");
            string output = string.Empty;

            for (int i = 0; i < words.Length; i++)
            {
                output += ReverseString(words[i]);
                output += " ";
            }

            Console.WriteLine("And now for your thing to be backwardized: ");
            Console.WriteLine(output);
            Console.WriteLine();
            Console.WriteLine("Wow, Amazing!");

            } while (RunAgain());

        }

        private static bool RunAgain()
        {

            Console.WriteLine();
            do
            {
                Console.Write("Do you want to backwardize more things? (y/n): ");
                var keyPressed = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.WriteLine();

                if (keyPressed == "y")
                {
                    Console.WriteLine("Sounds good! Lets Go!\n");
                    return true;
                }
                else if (keyPressed == "n")
                {
                    Console.WriteLine("We are sad to see you go. :(");
                    return false;
                }
                else
                {
                    Console.WriteLine("not a valid responce");
                    Console.WriteLine();
                }
            } while (true);
        }

        private static string GetValidatedUserInput()
        {
            string output = string.Empty;
            var done = false;

            do
            {
                Console.WriteLine("Write something below that you want reversed");
                Console.Write(" > ");
                string rawInput = Console.ReadLine();
                string invalidChars = @"[^A-Za-z ]";
                
                if (Regex.IsMatch(rawInput, invalidChars))
                {
                    Console.WriteLine();
                    Console.WriteLine("We only enter upper and lower case letters and spaces.");
                    Console.WriteLine();
                }
                else
                {
                    output = rawInput;
                    done = true;
                }


            } while (!done);

            return output;
        }

        private static string ReverseString(string s)
        {
            string output = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                output += s[i];
            }

            return output;
        }
    }
}
