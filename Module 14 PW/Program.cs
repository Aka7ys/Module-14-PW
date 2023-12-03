using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Пример текста для подсчета статистики
        string text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

        // Подсчет статистики
        Dictionary<string, int> wordStatistics = CountWordOccurrences(text);

        // Вывод статистики в виде таблицы
        Console.WriteLine("Слово\t\tЧастота");
        Console.WriteLine("----------------");
        foreach (var pair in wordStatistics)
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
        }
    }

    static Dictionary<string, int> CountWordOccurrences(string text)
    {
        string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordStatistics = new Dictionary<string, int>();

        foreach (var word in words)
        {
            string normalizedWord = word.ToLower();

            if (wordStatistics.ContainsKey(normalizedWord))
            {
                wordStatistics[normalizedWord]++;
            }
            else
            {
                wordStatistics[normalizedWord] = 1;
            }
        }

        return wordStatistics;
    }
}
