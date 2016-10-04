using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int TaskFor1Hour = Int32.Parse(Console.ReadLine());
            if (TaskFor1Hour < 8)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
