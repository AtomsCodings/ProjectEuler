/* Name: Ana Thomas
 * Date: 02/07/17
 * 
 * Special Pythagorean Triplet
 * 
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PythagoreanTriplet
    {
        public void display()
        {
            Console.WriteLine("\n 9. Special Pythagorean Triplet \n");
            Console.WriteLine("A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a2 + b2 = c2 \n");
            Console.WriteLine("For example, 32 + 42 = 9 + 16 = 25 = 52. \n");
            Console.WriteLine("There exists exactly one Pythagorean triplet for which a + b + c = 1000.  Find the product abc. \n");

            calc();
        }

        public void calc()
        {
            int aSum = 0;
            int bSum = 0;
            int cSum = 0;

            for (int a = 1; a < 1000; a++)
            {
                aSum = a * a;

                for (int b = a + 1; b < 1000; b++)
                {
                    bSum = b * b;

                    for (int c = b + 1; c < 1000; c++)
                    {
                        cSum = c * c;

                        if ((a + b + c == 1000) && (aSum + bSum == cSum))
                        {
                            Console.WriteLine(a + " + " + b + " + " + c + " = 1000");
                            Console.WriteLine(a + "^2 + " + b + "^2 = " + c + "^2");
                            break;
                        }
                    }
                }
            }
        }
    }
}
