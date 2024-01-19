using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_pattern_program_2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*         output
         --------------------------------
         12345
         2345
         345
         45
         5
         */
            Console.Write("Enter your number range :\t");
            int n=int.Parse(Console.ReadLine());
            for (int i=1;i<=n;i++)//row index loop
            {
                for(int j=i;j<=n;j++)//column index loop
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
