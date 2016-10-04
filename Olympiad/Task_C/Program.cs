using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // прочитай задачу, там не понятно нафига передается первый параметр (количество секций)
            // если я могу считать строку и посчитать количество элементов в строке. На что опираться на количество эл в строке
            //или на первое входное значение

            int CountElem = int.Parse(Console.ReadLine());
            int[] matrFieldForce = Console.ReadLine().Split(new char[] { ' ' }).Select(x=>int.Parse(x)).ToArray();
            int indexMiddleElemForMaxSumm = 0;
            int MaxSumm = 0;
                
            for (int i = 0; i < CountElem-2; i++)
            {
                if (MaxSumm < (matrFieldForce[i] + matrFieldForce[i + 1] + matrFieldForce[i + 2]))
                {
                    MaxSumm = matrFieldForce[i] + matrFieldForce[i + 1] + matrFieldForce[i + 2];
                    indexMiddleElemForMaxSumm = i + 2;
                }
                
            }
            Console.WriteLine($"{MaxSumm} {indexMiddleElemForMaxSumm}");
        }
    }
}
