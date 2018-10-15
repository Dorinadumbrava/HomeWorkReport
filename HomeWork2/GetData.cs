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
        static List<string[]> userInputs = new List<string[]>();

        public static void ReadAndSplit(string args)
        {
            if (args.Length >0)
            {
                    args.TrimEnd(';');  
            string[] tempUserInput = args.Split(' ');
                if (tempUserInput.Length == numberOfArguments)
            {
                userInputs.Add(tempUserInput);
            }
            else
            {
                Console.WriteLine("This input is not valid: '{0}", args);
                }
            }

        }

        public static void ShowUserInputs()
        {
            for (int i = 0; i < GetData.userInputs.Count; i++)
            {
                foreach (var Input in userInputs[i])
                {
                    Console.WriteLine(Input);
                }
                Console.WriteLine(" ");
            }
        }
    

    public static void ReadFromConsole()
    {
        List<string> temporaryInput = new List<string>();
        string consoleInput = " ";
        while (consoleInput.Length > 0)
        {
            consoleInput = Console.ReadLine();
            temporaryInput.Add(consoleInput);
        }
    }

    public static void ReadFromFile()
    {
        throw new NotImplementedException();
    }

    }

}
