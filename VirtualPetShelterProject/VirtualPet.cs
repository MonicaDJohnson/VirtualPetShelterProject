using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class VirtualPet
    {
        //Define fields
        private string name;
        private int hungerLevel;
        private int sleepyLevel;
        private int happyLevel;
        private int thirstLevel;
        private bool isPetHungry;
        private bool isPetSleepy;
        private bool isPetHappy;
        private bool isPetThirsty;
        private string petDescription;

        //Define properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }
        public int SleepyLevel
        {
            get { return this.sleepyLevel; }
            set { this.sleepyLevel = value; }
        }
        public int HappyLevel
        {
            get { return this.happyLevel; }
            set { this.happyLevel = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }
           
        public bool IsPetHungry
        {
            get { return this.isPetHungry; }
            set { this.isPetHungry = value; }
        }
        public bool IsPetSleepy
        {
            get { return this.isPetSleepy; }
            set { this.isPetSleepy = value; }
        }
        public bool IsPetHappy
        {
            get { return this.isPetHappy; }
            set { this.isPetHappy = value; }
        }

        public bool IsPetThirsty
        {
            get { return this.isPetThirsty; }
            set { this.isPetThirsty = value; }
        }

        public string PetDescription
        {
            get { return this.petDescription; }
            set { this.petDescription = value; }
        }


        public VirtualPet()
            {
                //Default constructor
            }

            public VirtualPet(string name, string petDescription)
            {
            this.name = name;
            this.petDescription = petDescription;
        }

            public VirtualPet(string name, int hungerLevel, int sleepyLevel, int happyLevel, int thirstLevel)//loaded constructor
            {
                this.name = name;
                this.hungerLevel = hungerLevel;
                this.sleepyLevel = sleepyLevel;
                this.happyLevel = happyLevel;
                this.thirstLevel = thirstLevel;
            }
             public VirtualPet(string name, int hungerLevel, int sleepyLevel, int happyLevel, int thirstLevel, string petDescription)//loaded constructor
             {
                this.name = name;
                this.hungerLevel = hungerLevel;
                this.sleepyLevel = sleepyLevel;
                this.happyLevel = happyLevel;
                this.thirstLevel = thirstLevel;
                this.petDescription = petDescription;
             }

        //Methods
        public void Tick(bool isPetHungry, bool isPetThirsty, bool isPetSleepy, bool isPetHappy)//I was not sure if I should put this method before or after Main.
            {
                Random r = new Random();
                hungerLevel = r.Next(0, 30);
                sleepyLevel = r.Next(0, 30);
                happyLevel = r.Next(0, 30);
                thirstLevel = r.Next(0, 30);

                if (hungerLevel < 10)
                {
                    isPetHungry = (true);
                }
                else
                {
                    isPetHungry = (false);
                }
                if (thirstLevel < 10)
                {
                     isPetThirsty = (true);
                }
                else
                {
                     isPetThirsty = (false);
                }

                if (sleepyLevel < 10)
                {
                    isPetSleepy = (true);
                }
                else
                {
                    isPetSleepy = (false);
                }
                if (happyLevel < 10)
                {
                    isPetHappy = (false);
                }
                else
                {
                    isPetHappy = (true);
                }
            }
            public void Feed()
            {
                hungerLevel--;
                if (hungerLevel < 10)
                {
                    hungerLevel = hungerLevel - 10;
                }
            }

            public void Water()
            {
                thirstLevel--;
                 if (thirstLevel < 10)
                 {
                    thirstLevel = thirstLevel - 10;
                 }

            }
             public void Sleep()
             {
                 sleepyLevel--;
                 if (sleepyLevel < 10)
                 {
                    sleepyLevel = sleepyLevel - 10;
                 }
             }
            public void Play()
            {
                happyLevel++;
                if (happyLevel < 10)
                {
                    happyLevel = happyLevel + 10;
                }
            }//play
        }//class
    }//namespace


