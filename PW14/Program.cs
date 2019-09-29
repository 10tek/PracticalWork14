using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW14
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            var tmpText = text.Replace(".", "");
            tmpText = tmpText.Replace(",", "");
            var words = tmpText.Split(' ');
            var statistics = new Dictionary<string, int>();
            foreach(var word in words)
            {
                if (statistics.ContainsKey(word))
                {
                    statistics[word]++;
                }
                else
                {
                    statistics.Add(word, 1);
                }
            }
            var i = 0;
            foreach(var word in statistics)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine($"{i}.");
                Console.SetCursorPosition(10, i);
                Console.WriteLine($"{word.Key}");
                Console.SetCursorPosition(30, i);
                Console.WriteLine($"{word.Value}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
