using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_pattern_program_3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*         output
        -------------------------------
        54321
        4321
        321
        21
        1
        */
            Console.Write("Enter your number range:\t ");
            int n=int.Parse(Console.ReadLine());
            for(int i=n; i>=1; i--)//row index loop
            {
                for(int j=i; j>=1;j--)//column index loop
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
