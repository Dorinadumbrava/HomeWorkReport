using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    static class EmployeeData
    {

       static public List<Employee> EmployeeList = new List<Employee>();
    
        static public void Show()
        {
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("{0} {1} with Id {2} got a salary of {3} on {4}", employee.FirstName, employee.LastName, employee.ID, employee.Salary, employee.Date);
            }
        }
        //public static void ShowUserInputs()
        //{
        //    for (int i = 0; i < GetData.userInputs.Count; i++)
        //    {
        //        foreach (var Input in GetData.userInputs[i])
        //        {
        //            Console.WriteLine(Input);
        //        }
        //        Console.WriteLine(" ");
        //    }
        //}

        public static void CreateUser()
        {
            foreach (var userInput in GetData.userInputs)
            {

                Employee e1 = new Employee();
                int temporarUserInt;
                int userID = 0;

                if (Int32.TryParse(userInput[0], out temporarUserInt))
                {
                    userID = temporarUserInt /*Int32.Parse(userInput[0])*/;
                    //Console.WriteLine(userID);
                }
                string userFirstName, userLastName;
                userFirstName = userInput[1];
                userLastName = userInput[2];
                int userSalary = 0;
                if (Int32.TryParse(userInput[3], out temporarUserInt))
                {
                    userSalary = temporarUserInt;
                    //Console.WriteLine(userSalary);
                }
                DateTime temporarUserDate;
                DateTime userDate = DateTime.Now;
                //how to predefine the date format in tryparse?
                if (DateTime.TryParse(userInput[4], out temporarUserDate))
                {
                    userDate = temporarUserDate;
                    //Console.WriteLine(userDate);
                }
                EmployeeData.EmployeeList.Add(new Employee { ID = userID, FirstName = userFirstName, LastName = userLastName, Date = userDate, Salary = userSalary });
            }
        }
}
