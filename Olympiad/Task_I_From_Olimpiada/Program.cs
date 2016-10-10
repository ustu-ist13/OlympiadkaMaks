using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_I_From_Olimpiada
{
    class Program
    {
        class res
        {
            public int value;
        }

        static void Main(string[] args)
        {
            int count_test = int.Parse(Console.ReadLine());
            Eq comp = new Eq();

            int[] input;
            int[] result = new int[count_test];
            int max_st = 0;
            int[] number;
            List<res> check_sum = new List<res>();
            long countForLoop = 0;
            List<List<res>> mass_for_res=new List<List<res>>();

            for (int i = 0; i < count_test; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                number = new int[input[2]];
                max_st = (int)(Math.Truncate((Math.Log(input[0], input[1]))));

                countForLoop = (int)Math.Pow((max_st + 1), (input[2]));
                mass_for_res.Clear(); 
                for (int j = 0; j < countForLoop-1; j++)
                {
                    check_sum.Clear();

                    //Console.WriteLine($"{string.Join("", number)}");

                    for (int k = 0; k < input[2]; k++)
                    {
                        check_sum.Add(new Task_I_From_Olimpiada.Program.res() {value=(int)Math.Pow(input[1], number[k])});
                    }
                    if (check_sum.Select(x=>x.value).Sum() == input[0])
                    {
                        if (!mass_for_res.Contains(check_sum.OrderBy(x => x.value).ToList(),comp))
                        {
                            result[i]++;
                            mass_for_res.Add(check_sum.OrderBy(x => x.value).ToList());
                        }
                    }
                    increment(input[2], max_st, number);           
                }
            }
            for (int i = 0; i < count_test; i++)
            {
                Console.WriteLine(result[i]);
            }
           
        }

        class Eq : IEqualityComparer<List<res>>
        {
            public bool Equals(List<res> x, List<res> y)
            {
                bool fl = true;
                if (x.Count == y.Count)
                {
                    for (int i = 0; i < x.Count; i++)
                    {
                        if (x[i].value != y[i].value)
                        {
                            fl = false;
                            break;
                        }
                    }
                }
                return fl;
            }

            public int GetHashCode(List<res> obj)
            {
                throw new NotImplementedException();
            }
        }

        static void increment(int len, int max_st, int[] number)
        {
            number[0]++;
            for (int i = 0; i < len ; i++)
            {
                if (number[i] > max_st)
                {
                    number[i + 1]++;
                    for (int j = 0; j < i + 1; j++)
                    {
                        number[j] = 0;
                    }
                }
             }
        }
    }
}
