/* Name: Ana Thomas
 * Date: 03/06/17
 * 
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class LargestPrime
    {
        public void display()
        {
            Console.WriteLine("\n 3. Largest Prime Factor \n");
            Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29.");
            Console.WriteLine("What is the largest prime factor of the number 600851475143? \n");

            Console.WriteLine("Largest prime factor of the number 600851475143 is " + calc());
        }

        public int calc()
        {
            int i = 0;
            long number = 600851475143;

            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                    number /= i;
            }
            return i;
        }      
    }
}
