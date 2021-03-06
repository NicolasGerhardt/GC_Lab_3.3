﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GC_LAB_3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            ConsoleColor defaultConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Welcome to the Backwardizer");
            Console.WriteLine();
            Console.ForegroundColor = defaultConsoleColor;

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

                Console.WriteLine("And now for your thing you typed to be Backwardized: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(output);
                Console.ForegroundColor = defaultConsoleColor;
                Console.WriteLine();
                Console.WriteLine("Wow, Amazing!");
                Console.WriteLine();

            } while (RunAgain());

        }

        private static bool RunAgain()
        {

            Console.WriteLine();
            do
            {
                Console.Write("Do you want to Backwardize more things? (y/n): ");
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
                    Console.WriteLine("Please press: Y for yes or N for no");
                    Console.WriteLine();
                }
            } while (true);
        }

        private static string GetValidatedUserInput()
        {
            string output = string.Empty;
            bool done;
            do
            {
                Console.WriteLine("Write something below that you want Backwardized");
                Console.Write(" > ");
                string rawInput = Console.ReadLine();
                string invalidChars = @"[^A-Za-z ]";

                if (Regex.IsMatch(rawInput, invalidChars))
                {
                    Console.WriteLine();
                    Console.WriteLine("We only accept spaces, upper case letters and lower case letters.");
                    Console.WriteLine();
                    done = false;
                }
                else
                {
                    output = rawInput;
                    done = true;
                }


            } while (!done);

            return output;
        }

        private static string ReverseString(string word)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char letter in word)
            {
                stack.Push(letter);
            }

            string output = string.Empty;

            while (stack.Count > 0)
            {
                output += stack.Pop();
            }

            return output;
        }
    }
}
