using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            string Answer = "";
            do
            {

                Console.WriteLine("Please enter a word.");
                string Word = Console.ReadLine().ToLower();


                HashSet<string> vowels = new HashSet<string> { "a", "e", "i", "o", "u" };

                if (vowels.Contains(Word.Substring(0, 1)))
                {
                    Console.Clear();
                    Vowel(Word);
                }
                else
                {
                    Console.Clear();
                    Consonant(Word);
                }

                Console.WriteLine("Would you like to translate another word?");
                Answer = Console.ReadLine().ToLower();


                while (!Regex.Match(Answer, @"^(yes|y|no|n)$").Success)

                {

                    Console.WriteLine("Please enter a valid input!");

                    Answer = Console.ReadLine();

                }

            } while (Answer  == "y" || Answer == "no");
        }

        public static void Vowel(string data)
        {
            Console.WriteLine(data + "way");
        }

        public static void Consonant(string data)
        {
            int index1 = data.IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u' });
            string index2 = data.Substring(0, index1);
            Console.WriteLine(data.Substring(index1) + index2 + "ay");
        }

    }
}
