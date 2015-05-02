using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 
                                          'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
            int vowels = countVowels(alphabet);
            int consonants = countConsonants(alphabet);

            Console.WriteLine("There are " + vowels + " vowels in the array.");
            Console.WriteLine("There are " + consonants + " consonants in the array.");
            Console.ReadLine();
            
        }
        static int countVowels(char[] alphabet)
        {
            int i = 0;

            foreach(char val in alphabet)
            {
                if (val == 'a' || val == 'e' || val == 'i' || val == 'o' || val == 'u')
                {
                    i++;
                }
            }
            return i;
        }
        static int countConsonants(char[] alphabet)
        {
            int i = 0;

            foreach (char val in alphabet)
            {
                if (val != 'a' && val != 'e' && val != 'i' && val != 'o' && val != 'u')
                {
                    i++;
                }
            }
            return i;
        }
    }
}
