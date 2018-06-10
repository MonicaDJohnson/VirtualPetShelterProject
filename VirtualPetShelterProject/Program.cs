using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager Louie = new Manager(12, 17, 13, 15, true, true, false, false);
            VirtualPetShelter BrightDay = new VirtualPetShelter("Carl", "Mike", "Sarah", "Maxine", "Bob", "Peep");
            Volunteer Nikki = new Volunteer();
            
            Console.WriteLine("Welcome to Bright Day Pet Shelter. Press 1 if you are a manager. Press 2 if you are a volunteer.");
            int menuResponseOne = int.Parse(Console.ReadLine());
            if(menuResponseOne == 1)
            {
                Console.WriteLine("Manager");
                Console.WriteLine("Select 1 to view the status of a pet. Select 2 to play with one of the pets. Select 3 to set up a pet adoption. Select 4 to add overtime for an employee.");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    int statusResponse = int.Parse(Console.ReadLine());
                    if(statusResponse == 1)
                    {

                    }

                    else if(statusResponse == 2)
                    {

                    }

                    else if(statusResponse == 3)
                    {

                    }

                    else if(statusResponse == 4)
                    {

                    }
                }

                else if(response == 2)
                {
                   
                }

                else if(response == 3)
                {
                    
                }

                else if(response == 4)
                {
                    
                }
                

            }

            if(menuResponseOne == 2)
            {
                Console.WriteLine("Volunteer");
                Console.WriteLine("Select 1 to check the status of a pet. Select 2 to play with one of the pets. Select 3 to sign up for overtime.");
                int response = int.Parse(Console.ReadLine());
                if (response == 1)
                {
                    int statusResponse = int.Parse(Console.ReadLine());
                    if (statusResponse == 1)
                    {

                    }

                    else if (statusResponse == 2)
                    {

                    }

                    else if (statusResponse == 3)
                    {

                    }

                    else if (statusResponse == 4)
                    {

                    }
                }

                else if(response == 2)
                {

                }

                else if(response == 3)
                {

                }

            }
             
            


        }
    }
}
