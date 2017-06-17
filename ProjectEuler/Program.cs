/* Name: Ana Thomas
 * Date: 02/0617
 * 
 * This contains solved problems from the Euler website https://projecteuler.net/
 * Solutions currently exist for:
 * 1. Multiples Of 3 and 5
 * 2. Even Fibonacci numbers
 * 3. Largest prime Ffctor
 * 4. Largest palindrome product
 * 5. Smallest Mutiple
 * 6. Sum Square Difference
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjectEuler
{
    class Program
    {
        public static void Main(string[] args)
        {
           // ProjectEuler.Mutiplesof one = new ProjectEuler.Mutiplesof();
          //  one.display();

          //  ProjectEuler.EvenFibonacci two = new ProjectEuler.EvenFibonacci();
          //  two.display();

         //   ProjectEuler.LargestPrime three = new ProjectEuler.LargestPrime();
          //  three.display();

          //  ProjectEuler.PalindromeProduct four = new ProjectEuler.PalindromeProduct();
         //   four.display();

            ProjectEuler.SmallestMultiple five = new ProjectEuler.SmallestMultiple();
            five.display();

            ProjectEuler.SumSquareDif six = new ProjectEuler.SumSquareDif();
            six.display();

            Console.ReadLine();
        }
    }
}
