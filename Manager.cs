using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Manager : Person
    {
        private List<Consultant> ConsultantList;

        public Manager(String Firstname, String Lastname, int Salary) : base(Firstname, Lastname, Salary)
        {
            this.ConsultantList = new List<Consultant>();
        }

        // Methods

        //Add a consultant under the manager
        private void AddConsultant(Consultant Consultant)
        {
            this.ConsultantList.Add(Consultant);
        }

        //See how many Consultant are under the manager (getter)
        private int NumberConsultant
        {
            get { return this.ConsultantList.Count; }
        }

    }
}
