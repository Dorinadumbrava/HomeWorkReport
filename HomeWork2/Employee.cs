using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
    class Employee 
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private int _salary;
        private DateTime _date;
        private List<int> idList;

        public int ID {
            get
            { return _id; }
            set
            {
                if (idList.Contains(ID))
                {
                    throw new Exception("This ID already exists");
                }
                else
                {
                    _id = ID;
                    idList.Add(ID);
                }
            }
        }
       

       

    }
}
