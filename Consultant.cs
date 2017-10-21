﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Consultant : Person
    {
        private List<Mission> Missionagenda;

        public Consultant(String Firstname, String Lastname, int Salary) : base(Firstname, Lastname, Salary)
        {
            this.Missionagenda = new List<Mission>();
        }

        //getter-setter

        public List<Mission> getMissionagenda()
        {
            return this.Missionagenda;
        }

        public void setMissionagenda(List<Mission> foo)
        {
            this.Missionagenda = foo;
        }

        public void addMission(Mission Mission)
        {
            //assert that mission agenda is empty
            this.Missionagenda.Add(Mission);
        }

        public void clearMissionagenda()
        {
            this.Missionagenda.Clear();
        }

        private void work()
        {
        }

    }
}
