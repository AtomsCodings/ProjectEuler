/* Name: Ana Thomas
 * Date: 04/06/17
 * 
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * 
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SmallestMultiple
    {
        public void display()
        {
            Console.WriteLine("\n 5. Smallest Multiple \n");
            Console.WriteLine("2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.");
            Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20? \n");

            calc();
        }

        public void calc()
        {
            long largestNo = 1;
            long foundNo = 0;


            for (int i = 1; i <= 20; i++)
            {
                largestNo = largestNo * i;
            }


            for (int j = 0; j < largestNo; j += 20)
            {
                if (j != 0)
                {
                    if ((j % 19 == 0) & (j % 18 == 0) & (j % 17 == 0) & (j % 16 == 0) & (j % 15 == 0))
                    {
                       if ((j % 14 == 0) & (j % 13 == 0) & (j % 12 == 0) & (j % 11 == 0) & (j % 10 == 0))                                                      
                       {
                            foundNo = j;
                            break;
                       }
        
                    }
                }
            }
            Console.WriteLine(foundNo);
        }  

    }
}
