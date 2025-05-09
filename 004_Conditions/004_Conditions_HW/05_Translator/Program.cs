using System;
using System.Text;

namespace Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть слово українською:");
            string inputWord = Console.ReadLine().ToLower();

            string translatedWord = inputWord switch
            {
                "погода" => "weather",
                "дощ" => "rain",
                "сніг" => "snow",
                "вітер" => "wind",
                "холодний" => "cold",
                "теплий" => "warm",
                "прохолодний" => "cool",
                "спекотний" => "hot",
                "сонячний" => "sunny",
                "хмарний" => "cloudy",
                _ => "isAbsent"
            };

            if (translatedWord == "isAbsent")
            {
                Console.WriteLine($"Переклад цього слова англійською в словнику відсутній");
            }
            else
            {
                Console.WriteLine($"Переклад слова \"{inputWord}\" англійською \"{translatedWord}\"");
            }
        }
    }
}
