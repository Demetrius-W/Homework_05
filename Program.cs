using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string mySentence;
            List<string> words = new List<string>();

            mySentence = Console.ReadLine();

            words = SplitSentence(mySentence);
            Console.WriteLine();
            PrintWords(words);
            Console.WriteLine();
            Console.Write(ReverseSentence(words));

            Console.ReadKey();
        }

        //Метод разделения строки на слова
        static List<string> SplitSentence(string sentence)
        {
            char[] execeptionSymbols = new char[]
            {
                ' ', '?', '!', '.', ','
            };

            List<string> words = new List<string>();
            words = sentence.Split(execeptionSymbols, StringSplitOptions.RemoveEmptyEntries).ToList();
            return words;
        }

        //Метод перестановки слов в предложении
        static string ReverseSentence(List<string> words)
        {
            Stack<string> reverseWords = new Stack<string>();
            string reverseSentence = String.Empty;

            for (int i = 0; i < words.Count; i++)
                reverseWords.Push(words[i]);

            foreach (var word in reverseWords)
                reverseSentence += word + " ";

            return reverseSentence;
        }

        //Метод вывода
        static void PrintWords(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
                Console.WriteLine(words[i]);
        }
    }
}
