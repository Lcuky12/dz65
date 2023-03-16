using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[30];
            Random random= new Random();

            int minNumber = 0;
            int maxNumber = 29;

            for ( int i = 0; i < arrayNumbers.Length; i++ )
            {
                arrayNumbers[i] = random.Next(minNumber, maxNumber + 1);
                Console.WriteLine(arrayNumbers[i]);
            }

            Console.WriteLine(" ");
        
            if (arrayNumbers [minNumber] > arrayNumbers[minNumber] + 1 )
            {
                Console.WriteLine(arrayNumbers[minNumber] + " ");
            }
            
            for (int i = 1; i < arrayNumbers.Length - 1; i++ )
            {
               
                if (arrayNumbers[i] > arrayNumbers[i - 1] && arrayNumbers[i] > arrayNumbers[i+ 1])
                {
                    Console.WriteLine(arrayNumbers[i] + " "); 
                }
            }
   
            if (arrayNumbers[maxNumber] > arrayNumbers[maxNumber] - 1 ) 
            {
                Console.WriteLine(arrayNumbers[maxNumber]+ " ");
            }
        } 
    }
}
