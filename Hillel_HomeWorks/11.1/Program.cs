using System;
using System.Text;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;


            string[] words = { "архітектура", "кондитерська", "інформатика", "торнадо", "бібліотека", "крокодил",
                "Україна", "фортеця", "конструктор", "водоспад", "математика", "література", "цукор",
                "потужність", "перемога", "вишуканість", "демократія", "шпалери", "філологічний", "ліжко",
                "ананас", "гірський", "оптиміст", "прибирання", "кохання", "картопля", "піраміда", "евакуація",
                "стратегія", "тренажер", "фабрика", "хімія", "чарівний", "щастя", "експрес", "вулкан",
                "дружина", "зміна", "культура", "мозаїка", "обчислення", "письменник", "реакція",
                "світлофор", "техніка", "фантазія", "художник" };

            Random rnd = new Random();
            string word_select = words[rnd.Next(0,words.Length)];

            char[] word_guess = new char[word_select.Length];
            

            int attempt = 10;
            bool letter_found = false;
            char letter_guess = ' ';
            Console.WriteLine("Спробуйте вгадати зашифроване слово!");
            for (int i = 0; i < word_guess.Length; i++)
            {
                word_guess[i] = '*';
                Console.Write($"{word_guess[i]}");
            }
            Console.WriteLine();
            Console.WriteLine($"Кількість літер у слові: {word_guess.Length}");
            Console.WriteLine($"Кількість спроб: {attempt}");

            while (attempt > 0) 
            {
                Console.Write("\nВведіть вашу букву:");
                letter_found = false;
                letter_guess = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < word_guess.Length; i++) 
                {
                    if(word_select[i]==letter_guess)
                    {
                        word_guess[i] = letter_guess;
                        letter_found = true;
                    }
                }
                if(letter_found)
                {
                    Console.WriteLine("Така літера є у слові!");
                    Console.Write("Поточний стан слова: ");
                    for (int i = 0; i < word_guess.Length; i++) 
                    {
                        Console.Write($"{word_guess[i]}");
                    }
                }
                else
                {
                    attempt--;
                    Console.WriteLine($"Такої літери немає. Кількість спроб: {attempt}");
                }

                bool GuessedWord = true;

                for (int i = 0; i < word_guess.Length; i++)
                {
                    if (word_guess[i] == '*')
                    {
                         GuessedWord= false;
                        break;
                    }
                }

                if (GuessedWord)
                {
                    Console.WriteLine($"\nВітаємо, ви вгадали слово! Зашифроване слово: {word_select}");
                    break;
                }
            }
            if (attempt == 0)
            {
                Console.WriteLine($"\nВи програли! Зашифроване слово було: {word_select}");
            }
        }
    }
}
