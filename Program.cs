using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    class Program
{
    static void Main()
    {

        Console.Write("Please enter n: ");
        double counter = double.Parse(Console.ReadLine());
        double sum = 1 + AddSum(counter); // calculate infinite sum 
        Console.WriteLine("Sum = {0:N3}", sum);



    }


    static double AddSum(double n)
    {
        double a = 0;

        for (double i = 1; i < n; i++)
        {
            if(i % 2 == 0)
            {
                a -= 1 / (i +1); // calculates negative fractions
            }

            else
            {
                a += 1 / (i +1); // calculates positive fractions
            }
        }

        return a;
    }

}

}