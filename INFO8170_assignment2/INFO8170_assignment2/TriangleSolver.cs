using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO8170_assignment2
{
     public class TriangleSolver
    {
        public string Analyze(int a,int b,int c)
        { 
           
             if ((a <= 0) || (b <= 0) || (c <= 0) || (float.IsNaN(a) || (float.IsNaN(b) || (float.IsNaN(c)))))
                        {
                            Console.WriteLine("please enter valid input");

                        }

                        else if (((a + b) > c) && ((b + c) > a) && ((c + a) > b))
                        {
                            Console.WriteLine("these inputs makes a triangle :)");
                            if (a == b && b == c && c == a)
                            {
                                Console.WriteLine("equilateral is a type of triangle");
                    return ("equilateral is a type of triangle");
                            }
                            else if ((a != b) && (b != c) && (c != a))
                            {
                                Console.WriteLine("scalene is a type of triangle");
                    return ("scalene is a type of triangle");

                    //Console.ReadLine();
                }
                            else if ((a == b) || (b == c) ||(c == a))
                            {
                                Console.WriteLine("isosceles is a type of triangle");
                    return ("isosceles is a type of triangle");
                    //Console.ReadLine();
                }
                            else
                            {
                                Console.WriteLine("Unpredictable");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                            
                        }
            return ("invalid inputs");
                     }
    }
}
