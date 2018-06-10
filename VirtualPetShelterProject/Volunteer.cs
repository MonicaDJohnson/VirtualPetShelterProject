using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Volunteer:Employee
    {
        //public int ThirstLevel { get; set; }
          //public int HungerLevel { get; set; }
          //public string volunteerJob { get; set; }
          public bool isPetFed { get; set; }
          public bool isPetWatered { get; set; }
          public int food;
          public int water;
          public int workDay;


        public override void FormerEmployee()
        {
            throw new NotImplementedException();
        }

        public override void NewEmployee()
        {
            throw new NotImplementedException();
        }

        public override void PunchIn()
        {
            throw new NotImplementedException();
            workDay = workDay + 5;
        }

        public bool FeedPets()
        {
            food = food + 2;
            return isPetFed = true;
        }

        public bool WaterPets()
        {
            water = water + 2;
            return isPetWatered = true;
        }

        
    }

}
