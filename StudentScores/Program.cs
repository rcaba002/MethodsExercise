using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many scores do you have? ");
            int numberOfScores = Convert.ToInt32(Console.ReadLine());

            int[] actualScores = new int[numberOfScores];
            
            for(int i = 0; i < numberOfScores; i++)
            {
                Console.Write("Enter a score: ");
                actualScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            formula(numberOfScores, actualScores);

            Console.ReadLine();
        }
        static void formula(int numberOfScores, int[] actualScores)
        {
            int highestNum = 0;
            int lowestNum = actualScores[0];
            int sum = 0;

            for (int i = 0; i < numberOfScores; i++)
            {
                if (actualScores[i] > highestNum)
                {
                    highestNum = actualScores[i];
                }
                else lowestNum = actualScores[i];
                sum = sum + actualScores[i];
            }

        Console.WriteLine("The highest number: " + highestNum);
        Console.WriteLine("The lowest number: " + lowestNum);
        Console.WriteLine("The average: " + sum / numberOfScores);
        }
    }
}