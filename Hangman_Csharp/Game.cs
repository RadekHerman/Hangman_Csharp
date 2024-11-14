using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;


namespace Hangman_Csharp
{
    
    class Game
    {    
        int lives = 7;
        readonly List<char> guessedLetters = new List<char>();
        readonly List<char> triedLetters = new List<char>();

        public void Play(string gameLanguage, string wordToGuess, HashSet<char> wordLettersSet)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(Language.outputStrings[gameLanguage]["banner"]);
                Console.WriteLine($"{Language.outputStrings[gameLanguage]["lives"]} {lives}\n");
                Console.WriteLine(Language.outputStrings[gameLanguage]["guesses"]);
                foreach (char c in triedLetters)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
                Console.WriteLine(Drawing.wisielec[lives]);
                printWordToGuess(wordToGuess, guessedLetters);
                Console.WriteLine(Language.outputStrings[gameLanguage]["guess_letter"]);

                string guess = Console.ReadLine();
                if ((!string.IsNullOrEmpty(guess)) && (guess.Trim().Length == 1))
                {            
                    char guessChar = char.Parse(guess.ToUpper());
                    if (Char.IsLetter(guessChar))
                        {
                        if (wordLettersSet.Contains(guessChar))
                        {
                            Console.WriteLine(Language.outputStrings[gameLanguage]["guessed"]);
                            wordLettersSet.Remove(guessChar);
                            guessedLetters.Add(guessChar);
                            triedLetters.Add(guessChar);
                        }
                        else
                        {
                            Console.WriteLine(Language.outputStrings[gameLanguage]["not_guessed"]);
                            lives--;
                            if (!triedLetters.Contains(guessChar))
                            {
                                triedLetters.Add(guessChar);
                            }
                            else
                            {
                                Console.WriteLine(Language.outputStrings[gameLanguage]["already_taken"]);
                            }
                        }
                    }

                    else
                        Console.WriteLine(Language.outputStrings[gameLanguage]["not_letter"]);
                }
                else
                {
                    Console.WriteLine(Language.outputStrings[gameLanguage]["only_one"]);
                }
                if (wordLettersSet.Count == 0)
                {
                    Console.WriteLine(Language.outputStrings[gameLanguage]["congrat"]);
                    Console.WriteLine(Language.outputStrings[gameLanguage]["press_any"]);
                    
                    break;
                }
                if (lives <= 0)
                {
                    Console.WriteLine(Language.outputStrings[gameLanguage]["end"]);
                    Console.WriteLine(wordToGuess);
                    Console.WriteLine(Language.outputStrings[gameLanguage]["press_any"]);
                    
                    break;
                }
                Console.WriteLine(Language.outputStrings[gameLanguage]["press_any"]);
                Console.ReadLine();
            }
        }

        static void printWordToGuess(string wordToGuess, List<char> guessedLetters)
        {
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (guessedLetters.Contains(wordToGuess[i]))
                {
                    Console.Write($"{wordToGuess[i]} ");
                }
                else
                {
                    Console.Write("-- ");
                }

            }
        }
    }


}
