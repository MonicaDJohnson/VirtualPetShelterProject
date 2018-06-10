using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    public abstract class Employee
    {
        public bool AdoptionStatus { get; set; }
        public int hungerLevel { get; set; }
        public int sleepyLevel { get; set; }
        public int happyLevel { get; set; }
        public int thirstLevel { get; set; }
        public bool isPetHungry { get; set; }
        public bool isPetSleepy { get; set; }
        public bool isPetHappy { get; set; }
        public bool isPetThirsty { get; set; }
        public string EmployeeSpecialty { get; set; }
        public string Overtime { get; set; }

        public Employee(int hungerLevel, int sleepyLevel, int happyLevel, int thirstLevel, bool isPetHungry, bool isPetSleepy, bool isPetHappy, bool isPetThirsty)
        {
            this.hungerLevel = hungerLevel;
            this.sleepyLevel = sleepyLevel;
            this.happyLevel = happyLevel;
            this.thirstLevel = thirstLevel;
            this.isPetHungry = isPetHungry;
            this.isPetSleepy = isPetSleepy;
            this.isPetHappy = isPetHappy;
            this.isPetThirsty = isPetThirsty;
        }
        public int EmployeeNumber { get; set; }

        public abstract void FormerEmployee();


        public abstract void NewEmployee();

        public abstract void PunchIn();


        public void HungryStatus()
        {
            if (hungerLevel < 10)
            {
                isPetHungry = (true);
            }
            else
            {
                isPetHungry = (false);
            }
        }
        public void ThirstyStatus()
        {
            Random r = new Random();
            thirstLevel = r.Next(0, 30);

            if (thirstLevel < 10)
            {
                isPetThirsty = (true);
            }
            else
            {
                isPetThirsty = (false);
            }
        }
        public void SleepyStatus()
        {
            Random r = new Random();
            sleepyLevel = r.Next(0, 30);

            if (sleepyLevel < 10)
            {
                isPetSleepy = (true);
            }
            else
            {
                isPetSleepy = (false);
            }
        }

        public void HappyStatus()
        {
            Random r = new Random();
            happyLevel = r.Next(0, 30);

            if (happyLevel < 10)
            {
                isPetHappy = (false);
            }
            else
            {
                isPetHappy = (true);
            }
        }


    }
}
