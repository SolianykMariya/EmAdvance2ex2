using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        public static void Swap(ref int num1,ref int num2)
        {
            var temp = num1;
            num1 = num2;
            num2 = temp;
        }
        public static int[] BubbleSort(int[] array)
        {
            var length = array.Length;
            for(var i = 1; i < length;i++)
            {
               
                for (var j = 0; j < length-i; j++)
                {
                    
                    if (array[j] > array[j + 1])
                    {
                       Swap(ref array[j],ref array[j + 1]);
                    }
                }
            }
           
            return array;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int[] randomNumbers = new int[100];

            Random rand = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(100, 901);
            }

            
            Console.WriteLine("Друге найменше число: " + BubbleSort(randomNumbers)[1]);
          


            
        }
    }
}
