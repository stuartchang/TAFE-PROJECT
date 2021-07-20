using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Stuart Chang
// 20/7/21
// Flow Rate Program
// Question 1. Program for a electronic sensor at hydroelectric dam that monitors water flows rate into a turbine; Function: It reads a single integer value which represents the water flow rate and display a message which indicates the state of the system.
namespace DamV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int flowrate = 0;
            bool keyBoardInput = false;

            Console.Write("What is the flowrate?");
            keyBoardInput = int.TryParse(Console.ReadLine(), out flowrate);

            if (keyBoardInput == true)
            {
                if (flowrate < 75)
                    Console.WriteLine("Warning Flow Rate Low");
                else if (flowrate > 120)
                    Console.WriteLine("Warning Flow Rate High");
                else
                    Console.WriteLine("Flow Rate OK");
            }
            else
                Console.WriteLine("Error");
            Console.ReadLine();
        }
    }
}


