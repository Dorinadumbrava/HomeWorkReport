using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chose a working method");
            Console.WriteLine( "Write 'F' to read from file, 'I' to pass arguments and pres Enter to to read from console" );
            string userChoice = Console.ReadLine().ToUpper();
            switch (userChoice)
            {
                case "F":
                {
                        GetData.ReadFromFile();
                }
                    break;
                case "I":
                    {
                        Console.WriteLine("The data will be taken from arguments");
                        GetData.ReadFromCmd(args);
                        Console.ReadKey();
                    }
                    break;
                case "":
                    {
                        GetData.ReadFromConsole();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
