/* Name: Ana Thomas
 * Date: 16/06/17
 * 
 * The sum of the squares of the first ten natural numbers is,
 * 1^2 + 2^2 + ... + 10^2 = 385
 * 
 * The square of the sum of the first ten natural numbers is,
 * (1 + 2 + ... + 10)^2 = 552 = 3025
 * 
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640
 * 
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SumSquareDif
    {
        public void display()
        {
            Console.WriteLine("\n 6. Sum Square Difference \n");
            Console.WriteLine("The sum of the squares of the first ten natural numbers is,");
            Console.WriteLine("1^2 + 2^2 + ... + 10^2 = 385 \n");
            Console.WriteLine("The sum of the squares of the first ten natural numbers is,");
            Console.WriteLine("(1 + 2 + ... + 10)^2 = 552 = 3025 \n");
            Console.WriteLine("Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.");
            Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum. \n");


            calc();
        }

        public void calc()
        {
            long sumOfSquares = 0;
            long sumOfSquared = 0;
            

            for (int i = 1; i < 101; i++)
            {
                sumOfSquares = sumOfSquares + (i * i);
                sumOfSquared = sumOfSquared + i;
            }
            sumOfSquared = sumOfSquared * sumOfSquared;
        
            Console.WriteLine("Using a loop: " + (sumOfSquared - sumOfSquares));

            //**or**

            sumOfSquares = 0;
            sumOfSquared = 0;
            int N = 100;

            sumOfSquared = N * (N + 1) / 2;
            sumOfSquared = sumOfSquared * sumOfSquared;
            sumOfSquares = (N * (N + 1) * (2 * N + 1)) / 6;

            Console.WriteLine("Or using a more mathematical approach: " + (sumOfSquared - sumOfSquares));

        }

    }
}
