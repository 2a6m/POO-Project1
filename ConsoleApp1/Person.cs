using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        private readonly String Firstname;
        private readonly String Lastname;
        private int Salary;
        private int Personnalaccount;

        public Person(String Firstname, String Lastname, int Salary)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Salary = Salary;
            this.Personnalaccount = 0;
        }

        void getPaid()
        {

        }
        


    }
}
