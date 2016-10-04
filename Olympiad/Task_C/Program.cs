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
            //тренировка со строками 
            // прочитай задачу, там не понятно нафига передается первый параметр (количество секций)
            // если я могу считать строку и посчитать количество элементов в строке. На что опираться на количество эл в строке
            //или на первое входное значение
            int[] matrFieldForce = Console.ReadLine().Split(new char[] { ' ' }).Select(x=>int.Parse(x)).ToArray();
            Console.WriteLine(String.Join("/",matrFieldForce));
        }
    }
}
