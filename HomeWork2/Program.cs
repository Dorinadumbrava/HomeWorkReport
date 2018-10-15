using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
                        string [] fileUserInputs = System.IO.File.ReadAllLines(@"C:\Dorina Projects\HomeWorkReport\HomeWork2\UserData.txt");
                        if (fileUserInputs.Length > 0)
                        {
                            foreach (string input in fileUserInputs)
                            {
                                GetData.ReadAndSplit(input);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no arguments inserted");
                        }
                        GetData.ShowUserInputs();
                        Console.ReadKey();
                    }
                    break;
                case "I":
                    {
                        Console.WriteLine("The data will be taken from arguments");
                        if (args.Length > 0)
                        {
                            foreach (string input in args)
                            {
                                GetData.ReadAndSplit(input);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no arguments inserted");
                        }
                        GetData.ShowUserInputs();
                        Console.ReadKey();
                    }
                    break;
                case "":
                    {
                        Console.WriteLine("Write your user data: ");
                        Console.WriteLine("Once you finsh your inputs, press Enter.");
                        string consoleInput = " ";
                        while (consoleInput.Length > 0)
                        {
                            consoleInput = Console.ReadLine();
                            GetData.ReadAndSplit(consoleInput);
                        }
                        GetData.ShowUserInputs();
                        Console.ReadKey();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
