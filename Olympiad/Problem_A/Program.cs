using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_A
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>();
            List<string> resultList = new List<string>();
            for (int i = 0; i < int.Parse(Console.ReadLine()); i++)
            {
                int[] inp = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < inp[0]; j++)
                {
                    inputList.Add(Console.ReadLine());
                }  
                //inputList.
                       
            }
            

        }
    }
}
