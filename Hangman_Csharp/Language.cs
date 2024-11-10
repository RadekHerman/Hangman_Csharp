using System.Collections.Generic;

namespace Hangman_Csharp
{
    class Language
    {
        public static Dictionary<string, Dictionary<string, string>> outputStrings = new Dictionary<string, Dictionary<string, string>>()
    {
        {
            "PL", new Dictionary<string, string>()
            {
                { "choose_dict", "Wybierz słownik z którego zostanie pobrane słowo.\n(1) Polski lub (2) Angielski." },
                { "banner", " +++++++++++++++++\n+ W I S I E L E C +\n +++++++++++++++++\n\n" },
                { "lives", "Szubienica czeka.. Pozostało prób:" },
                { "last_chance", "OSTATNIA PRÓBA!" },
                { "guess_letter", "\nPodaj literę: " },
                { "guessed", "ODGADŁEŚ!!" },
                { "already_taken", "Już wybierałeś tę literę, spróbuj jeszcze raz.\n" },
                { "guesses", "Wybierane do tej pory: " },
                { "press_any", "\nNaciśnij ENTER klawisz aby kontynuować." },
                { "not_guessed", "NIE ODGADŁEŚ!" },
                { "only_one", "Podaj jedną literę" },
                { "end", "Koniec gry... odpowiedź:" },
                { "congrat", "GRATULACJE!!!!" },
                { "play_again", "Czy chcesz zagrać jeszcze raz? (t/n): " },
                { "yes", "t" },
                { "bye", "pa" }
            }
        },
        {
            "EN", new Dictionary<string, string>()
            {
                { "choose_dict", "Please choose the dictionary:\n(1) Polish or (2) English." },
                { "banner", " +++++++++++++++++\n + H A N G M A N +\n +++++++++++++++++\n\n" },
                { "lives", "The gallows is waiting. The lives left:" },
                { "last_chance", "The Last Chance!" },
                { "guess_letter", "\nGuess the letter: " },
                { "guessed", "YOU GUESSED!!" },
                { "already_taken", "You have already chosen that letter, please try again.\n" },
                { "guesses", "The letters you have tried so far: " },
                { "press_any", "\nPress ENTER to continue." },
                { "not_guessed", "NOT GUESSED!!" },
                { "only_one", "Only one letter please." },
                { "end", "Game over... word: " },
                { "congrat", "CONGRATULATIONS!!!!" },
                { "play_again", "Do you want to play again? (y/n): " },
                { "yes", "y" },
                { "bye", "bye" }
            }
        }

        };
    }

}