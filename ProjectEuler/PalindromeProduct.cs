/* Name: Ana Thomas
 * Date: 06/06/17
 * 
 * Largest Palindrome Product
 * 
 * A palindromic number reads the same both ways.  
 * The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class PalindromeProduct
    {
        public void display()
        {
            Console.WriteLine("\n 4. Largest Palindrome Product \n");
            Console.WriteLine("A palindromic number reads the same both ways.");
            Console.WriteLine("The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.");
            Console.WriteLine("Find the largest palindrome made from the product of two 3-digit numbers. \n");

            var tuple = calc();
            Console.WriteLine(tuple.Item1 + " * " + tuple.Item2 + " = " + tuple.Item3); 
        }

        public Tuple<int, int, int> calc()
        {
            int noOneTwo = 0;
            string sOneTwo = "";
            int noLargest = 0;
            int noOne = 0;
            int noTwo = 0;

            for (int i = 999; i > 99; i-- )
            {
                for (int j = 999; j > 99; j--)
                {
                    noOneTwo = i * j;
                    sOneTwo = Convert.ToString(noOneTwo);

                    char[] array = sOneTwo.ToCharArray();
                    Array.Reverse(array);
                    string backwards = new string(array);

                    if (sOneTwo == backwards)
                    {
                        if (noOneTwo > noLargest)
                        {
                            noLargest = noOneTwo;
                            noOne = i;
                            noTwo = j;
                        }
                    }     
                } 
            }
            return new Tuple<int, int, int>(noOne, noTwo, noLargest);
        }
    }
}
 

