/* Name: Ana Thomas
 * Date: 02/06/17
 * 
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler
{
    public class Mutiplesof
    {

        public void display()
        {
            Console.WriteLine("\n 1. Multiples of \n");
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. ");
            Console.WriteLine("The sum of these multiples is 23.  Find the sum of all the multiples of 3 or 5 below 1000. \n");

            calc();
            
        }

        public void calc()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Total Sum: " + sum);
        }
        
    }
}
