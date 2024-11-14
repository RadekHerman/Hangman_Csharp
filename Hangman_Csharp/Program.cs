using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Hangman_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            if (!System.Globalization.CultureInfo.CurrentCulture.Name.StartsWith("pl"))
            {
                Console.InputEncoding = System.Text.Encoding.UTF8;
            }

            while (true)
            {
                string gameLanguage = ChooseGameLanguage();
                string wordToGuess = SelectRandomWord(gameLanguage);
                // making a set of characters (remove doubles) 
                HashSet<char> wordLettersSet = MakeSet(wordToGuess);
                Game game = new Game();
                Thread.Sleep(1500);
                game.Play(gameLanguage, wordToGuess, wordLettersSet);
                Console.ReadLine();
            }
        }

        static HashSet<char> MakeSet(string wordToGuess)
        {
            char[] wordLetters = wordToGuess.ToCharArray();
            HashSet<char> wordLettersSet = new HashSet<char>();
            foreach (var c in wordLetters)
            {
                wordLettersSet.Add(c);
            }
            return wordLettersSet;
        }

        static string SelectRandomWord(string gameLanguage)
        {
            string filePath = "";
            string wordToGuess;

            while (filePath.Equals(""))
            {
                Console.WriteLine(Language.outputStrings[gameLanguage]["choose_dict"]);
                string wordDictionary = Console.ReadLine();
                if (wordDictionary == "1")
                    filePath = "slowa.txt";
                if (wordDictionary == "2")
                    filePath = "words.txt";
            }

            while (true)
            {
                int totalLines = File.ReadLines(filePath).Count();
                Random random = new Random();

                int randomLineNumber = random.Next(1, totalLines + 1);
                wordToGuess = ReadSpecificLine(filePath, randomLineNumber).ToUpper();
                if (!string.IsNullOrEmpty(wordToGuess))
                    break;
            }

            return wordToGuess;
        }


        static string ReadSpecificLine(string filePath, int lineNumber)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int i = 1; i < lineNumber; i++)
                {
                    reader.ReadLine(); // Skip lines until we reach the desired one
                }
                return reader.ReadLine(); // Return the specific line
            }
        }

        static string ChooseGameLanguage()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to HANGMAN.");
                Console.WriteLine("Please choose language version of the game.");
                Console.WriteLine("(1) for Polish, (2) for English");
                Console.WriteLine("(3) Exit Game");
                string language = Console.ReadLine();
                if (language == "1")
                    return "PL";
                else if (language == "2")
                    return "EN";
                else if (language == "3")
                    Environment.Exit(0);
            }

        }

    }
}
