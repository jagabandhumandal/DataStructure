using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    class DataAlgoMain
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size:");
            size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Sorting-");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            BubbleSort bubble = new BubbleSort();
            int[] result = bubble.BubbleSortAlgo(numbers, size);
            Console.WriteLine("After Sorting-");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }

        
    }
    
}
