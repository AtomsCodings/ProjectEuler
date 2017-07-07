/* Name: Ana Thomas
 * Date: 03/07/17
 * 
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * 
 * Find the sum of all the primes below two million.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler
{
    class SumOfPrimes
    {
        public void display()
        {
            Console.WriteLine("\n 10. Summation of Primes \n");
            Console.WriteLine("The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. \n");
            Console.WriteLine("Find the sum of all the primes below two million. \n");

            calc();
        }

        public void calc()
        {
            //need to implement the sieve method as my current approach is too slow

            long prime = 2;
            long sum = 3;
            bool isPrime = false;

            do
            {
                isPrime = true;

                for (int i = 3; i < prime; i = i + 2)
                {
                    if (prime % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    sum += prime;

                prime++;

            }
            while (prime < 2000000);

            Console.WriteLine("Prime: " + prime + " Sum: " + sum);
            Console.ReadLine();
        }

    


        }
    
}
