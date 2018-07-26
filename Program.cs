using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var max = CalculateWords(".");

            Console.Write(max);
        }

        private static int  CalculateWords(string text)
        {
            var sentences = text.Split(new[] { '.', '?', '!' });

            var words = sentences
                .Where(sentence => !string.IsNullOrWhiteSpace(sentence))
                .Select(sentence => Regex.Split(sentence.Trim(), @"\s+"));

            return words.Count() > 0 ? words.Max(word => word.Count()) : 0;

        }
    }
}
