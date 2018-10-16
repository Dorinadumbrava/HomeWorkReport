using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    static class GetData
    {
        static int numberOfArguments = 6;
        public static List<string[]> userInputs = new List<string[]>();

        public static void ReadAndSplit(string args)
        {
            if (args.Length >0)
            {
            string[] tempUserInput = args.Split(' ');
                Console.WriteLine(" {0} + {1}", args, tempUserInput.Count());
                if (tempUserInput.Length == numberOfArguments)
            {
                    tempUserInput = tempUserInput.Where(w => w != tempUserInput[tempUserInput.Length - 1]).ToArray();
                userInputs.Add(tempUserInput);
            }
            else
            {
                Console.WriteLine("This input is not valid: '{0}", args);
                }
            }

        }

        
    
        
        }

    

    }

}
