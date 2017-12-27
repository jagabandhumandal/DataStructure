using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    public class BubbleSort
    {
        /* Bubble sort follows a simple logic. It compares adjacent elements in a loop and swaps them if they are not in order.
 
          Bubble sort is named this way because, in this sorting method, the smaller elements gradually bubble up to the top of the list.
 
          Bubble sort has worst-case and average complexity both О(n2), where n is the number of items being sorted.*/

        public int[] BubbleSortAlgo(int[] numbers, int size)
        {
            int temp;
            for (int i = 0; i <= size - 2; i++)
            {
                for (int j = 0; j <= size - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
