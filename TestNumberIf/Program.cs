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
                if (number > 10)
                    Console.WriteLine("More than 10");
                else if (number < 10)
                    Console.WriteLine("Less than 10");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadLine();
            
        }
    }
}
