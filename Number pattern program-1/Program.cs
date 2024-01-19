using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_pattern_program_1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*   output
         ---------------------------------------
        12345
        1234
        123
        12
        1
        */
            Console.Write("Enter the range:\t");
            int n=int.Parse(Console.ReadLine());
            for(int i=n;i>=1;i--)//row index loop
            {
                for (int j=1;j<=i;j++)//column index loop
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
