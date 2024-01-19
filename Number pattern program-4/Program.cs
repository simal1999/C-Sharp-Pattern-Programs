using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_pattern_program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*         output
        -------------------------------
            54321
            5432
            543
            54
            5
            */
            Console.Write("Enter your number range:\t");
            int n=int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)//row index loop
            {
                for (int j = n; j >= i; j--)//column index loop
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
