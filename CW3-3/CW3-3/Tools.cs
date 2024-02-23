using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW3_3
{
    internal class Tools
    {
        public void FindMostNumber(string inputNumbers)
        {
            int maxElement = 0;
            int indexOfMaxelemnt = 0;
            int[] number = new int[10];
            // {0,1,2,3,4,5,6,7,8,9}
            // 2223654
            foreach (char item in inputNumbers)
            {
                number[Convert.ToInt32(item.ToString())] += 1;
            }
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] > maxElement)
                {
                    maxElement = number[index];
                    indexOfMaxelemnt = index;
                }
            }
            //string.Format("maximom {0}:{1}" , indexOfMaxelemnt , maxElement);
            Console.WriteLine("maximom {0}:{1}", indexOfMaxelemnt, maxElement);
        }
    }
}
}
