using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFO8170_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleSolver t = new TriangleSolver();
            int a1, b1, c1;
            string a, b, c;
       
            string value = string.Empty;

            bool validMenuSelection = false;
            while (validMenuSelection == false)
            {
                Console.WriteLine("1 Enter the triangle dimensions");
                Console.WriteLine("2 Exit");

                value = Console.ReadLine();

                switch (value)
                {
                    case "1":
                        Console.WriteLine("Please enter 3 desired value to check the type of the triangle");
                        a= Console.ReadLine();

                        bool isNum = int.TryParse(a, out a1);
                        if (!(isNum))
                        {
                            Console.WriteLine("not a valid");
                        }

                        b = Console.ReadLine();
                        bool isb = int.TryParse(b, out b1);
                        if (!(isb))
                        {
                            Console.WriteLine("not a valid");
                        }

                        c= Console.ReadLine();
                        bool isc = int.TryParse(c, out c1);
                        if (!(isc))
                        {
                            Console.WriteLine("not a valid");
                        }
                        t.Analyze(a1, b1, c1);
                        break;
                    case "2":
                        {
                            System.Environment.Exit(0);
                            break;
                        }

                    default:
                        Console.WriteLine("please enter the valid option");
                        break;
                }
             
            }

        }
    }
}
