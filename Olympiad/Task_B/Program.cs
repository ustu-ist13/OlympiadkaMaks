using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string Seat = Console.ReadLine();

            if (int.Parse(Seat.Substring(0, Seat.Count() - 1)) < 3)
            {
                switch (Seat[Seat.Count() - 1])
                {
                    case 'A':
                    case 'D':
                        Console.WriteLine("window");
                        break;

                    case 'B':
                    case 'C':
                        Console.WriteLine("aisle");
                        break;
                }
            }
            else
            {
                if (int.Parse(Seat.Substring(0, Seat.Count() - 1)) < 21)
                {
                    switch (Seat[Seat.Count() - 1])
                    {
                        case 'A':
                        case 'F':
                            Console.WriteLine("window");
                            break;

                        case 'B':
                        case 'C':
                        case 'D':
                        case 'E':
                            Console.WriteLine("aisle");
                            break;
                    }
                }
                else
                {
                    if (int.Parse(Seat.Substring(0, Seat.Count() - 1)) < 66)
                    {
                        switch (Seat[Seat.Count() - 1])
                        {
                            case 'A':
                            case 'K':
                                Console.WriteLine("window");
                                break;

                            case 'C':
                            case 'D':
                            case 'G':
                            case 'H':
                                Console.WriteLine("aisle");
                                break;

                            case 'B':
                            case 'E':
                            case 'F':
                            case 'J':
                                Console.WriteLine("neither");
                                break;
                        }

                    }
                }
            }

        }
    }
}
