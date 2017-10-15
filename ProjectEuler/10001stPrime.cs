/* Name: Ana Thomas
 * Date: 20/06/17
 * 
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class _10001stPrime
    {
        public void display()
        {
            Console.WriteLine("\n 7. 1001st Prime \n");
            Console.WriteLine("By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.");
            Console.WriteLine("What is the 10001st prime number?");

            Console.WriteLine("1001st prime number is: " + calc());
        }

        public long calc()
        {
            List<long> primeNumbers = new List<long>() { 2 };
            for (long i = 3; i < long.MaxValue; i += 2)
            {
                if (!primeNumbers.Any(p => (i % p) == 0))
                {
                    primeNumbers.Add(i);
                    if (primeNumbers.Count == 10001)
                    {
                        return i;
                        break;
                    }
                }
            }
            return 0;
        }
    }
}