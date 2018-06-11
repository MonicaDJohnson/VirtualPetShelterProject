using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Manager : Employee
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

        public Manager(int hungerLevel, int sleepyLevel, int happyLevel, int thirstLevel, bool isPetHungry, bool isPetSleepy, bool isPetHappy, bool isPetThirsty)
        {
            this.HungerLevel = hungerLevel;
            this.SleepyLevel = sleepyLevel;
            this.HappyLevel = happyLevel;
            this.ThirstLevel = thirstLevel;
            this.IsPetHungry = isPetHungry;
            this.IsPetSleepy = isPetSleepy;
            this.IsPetHappy = isPetHappy;
            this.IsPetThirsty = isPetThirsty;
        }

        public override void NewEmployee()
        {
            throw new NotImplementedException();
        }

        public override void FormerEmployee()
        {
            throw new NotImplementedException();
        }

        public override void PunchIn()
        {
            throw new NotImplementedException();
            Overtime = Overtime + 1;
        }

        public bool Adoption()
        {
            return AdoptionStatus;
        }


        public bool HungryStatus()
        {
            Random r = new Random();
            HungerLevel = r.Next(0, 30);

            if (HungerLevel < 10)
            {
                IsPetHungry = (true);
            }
            else
            {
                IsPetHungry = (false);
            }

            return IsPetHungry;
        }
        public bool ThirstyStatus()
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

            return IsPetThirsty;

            
        }
        public bool SleepyStatus()
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

            return IsPetSleepy;
        }

        public bool HappyStatus()
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

            return IsPetHappy;
        }

        public void PetPlaying()
        {
            HappyLevel = HappyLevel++;
        }
        
        public void PetFeeding()
        {
            HungerLevel = HungerLevel--;
        }

        public void PetWatering()
        {
            ThirstLevel = ThirstLevel--;
        }

        public void PetSleeping()
        {
            SleepyLevel = SleepyLevel--;
        }
    }//class
}


    

