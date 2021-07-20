using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Stuart Chang
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool keyBoardInput = false;
            {
                Console.Write("What is the number");
                keyBoardInput = int.TryParse(Console.ReadLine(), out number);
            }
            if (keyBoardInput == true)
            {
                int range = (number / 10) * 10;
                switch (range)
                {
                    case 0:
                    case 1:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Less than 10");
                        break;
                    default:
                        Console.WriteLine("More than 10");
                        break;
                }

            }
            else
                Console.WriteLine("Invalid");
            Console.ReadLine();

        }
    }
}
