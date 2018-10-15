using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    static class GetData 
    {
        static int numberOfArguments = 5;

        public static void ReadAndSplit(string[] args)
        {
            
            if (args.Length > 0)
            {
                List<string[]> userInputs = new List<string[]> ();
                foreach (string userInput in args)
                {
                    string[] tempUserInput = userInput.Split(' ');
                    if (tempUserInput.Length == numberOfArguments)
                    {
                        userInputs.Add(tempUserInput);
                    }
                    else
                    {
                        Console.WriteLine("This input is not valid: '{0}'", userInput);
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no arguments inserted");
            }
        }

        public static void ReadFromConsole()
        {
            throw new NotImplementedException();
        }

        public static void ReadFromFile()
        {
            throw new NotImplementedException();
        }

        
    }
}
