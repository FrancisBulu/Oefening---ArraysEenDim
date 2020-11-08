using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening___ArraysEenDim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef 10 getallen in");

            int[] getalArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                getalArray[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"getal nummer {i + 1}");
            }
            Console.WriteLine("Jouw getallen zijn: ");
            for (int j = 0; j < getalArray.Length; j++)
            {
                Console.Write($" {getalArray[j]}, ");
            }


        }
    }
}
