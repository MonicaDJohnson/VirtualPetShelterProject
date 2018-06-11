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
        public int HungerLevel { get; set; }
        public int SleepyLevel { get; set; }
        public int HappyLevel { get; set; }
        public int ThirstLevel { get; set; }
        public bool IsPetHungry { get; set; }
        public bool IsPetSleepy { get; set; }
        public bool IsPetHappy { get; set; }
        public bool IsPetThirsty { get; set; }
        public string EmployeeSpecialty { get; set; }
        public string Overtime { get; set; }

        
        public int EmployeeNumber { get; set; }

        public abstract void FormerEmployee();


        public abstract void NewEmployee();

        public abstract void PunchIn();


        public void HungryStatus()
        {
            if (HungerLevel < 10)
            {
                IsPetHungry = (true);
            }
            else
            {
                IsPetHungry = (false);
            }
        }
        public void ThirstyStatus()
        {
            Random r = new Random();
            ThirstLevel = r.Next(0, 30);

            if (ThirstLevel < 10)
            {
                IsPetThirsty = (true);
            }
            else
            {
                IsPetThirsty = (false);
            }
        }
        public void SleepyStatus()
        {
            Random r = new Random();
            SleepyLevel = r.Next(0, 30);

            if (SleepyLevel < 10)
            {
                IsPetSleepy = (true);
            }
            else
            {
                IsPetSleepy = (false);
            }
        }

        public void HappyStatus()
        {
            Random r = new Random();
            HappyLevel = r.Next(0, 30);

            if (HappyLevel < 10)
            {
                IsPetHappy = (false);
            }
            else
            {
                IsPetHappy = (true);
            }
        }


    }
}
