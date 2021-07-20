using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Stuart Yen Yung Chang
// 20/7/21
// UV Index Program
// Question 2. Console Application that reads the UV Index (reads an integer input from the console) and then displays the UV Index Category as a message with background and text colours 
namespace UVIndexV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int UVindex = 0;
            bool keyBoardInput = false;
            Console.Write("What is the UV Index");
            keyBoardInput = int.TryParse(Console.ReadLine(), out UVindex);
            if (keyBoardInput == true)
            {
                switch (UVindex)
                {
                    case 1:
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Low");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Moderate");
                        break;
                    case 6:
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("High");
                        break;
                    case 8:
                    case 9:
                    case 10:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Very High");
                        break;
                    case 11:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Extreme");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("That Value Does Not Compute!");
                        break;
                }
            }
            Console.WriteLine("Program has ended");
            Console.ReadLine();
        }
    }
}
