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
            string exitMain = "no";
            Manager Louie = new Manager(12, 17, 13, 15, true, true, false, false);
            VirtualPetShelter BrightDay = new VirtualPetShelter("Carl", "Mike", "Sarah", "Maxine", "Bob", "Peep");
            Volunteer Nikki = new Volunteer();


            Console.WriteLine("Welcome to Bright Day Pet Shelter. Press 1 if you are a manager. Press 2 if you are a volunteer.");
            while (exitMain == "no")
            {
                int menuResponseOne = int.Parse(Console.ReadLine());
                if (menuResponseOne == 1)
                {
                    Console.WriteLine("Manager");
                    Console.WriteLine("Select 1 to view the status of a pet. Select 2 to play with one of the pets. Select 3 to set up a pet adoption. /*Select 4 to add overtime for an employee.*/");//I commented out the last option(but it still shows) because that particular option is crashing the program, and I'm not sure why.
                    int response = int.Parse(Console.ReadLine());
                    if (response == 1)
                    {
                        Console.WriteLine("Select 1 to check hunger status. Select 2 to check thirst status. Select 3 to check sleepiness status. Select 4 to check happiness status.");
                        int statusResponse = int.Parse(Console.ReadLine());
                        if (statusResponse == 1)
                        {
                            int action;
                            Console.WriteLine(Louie.HungryStatus());
                            if (Louie.HungryStatus() == true)
                            {
                                Console.WriteLine("Your pet is hungry. Press 1 to give it food.");
                                action = int.Parse(Console.ReadLine());
                                if (action == 1)
                                {
                                    Louie.PetFeeding();
                                    Console.WriteLine("You have now given your pet food.");
                                }

                            }

                            else if (Louie.HungryStatus() == false)
                            {
                                Console.WriteLine("Your pet has enough food.");
                            }
                        }

                        else if (statusResponse == 2)
                        {
                            int action;
                            Console.WriteLine(Louie.ThirstyStatus());
                            if (Louie.ThirstyStatus() == true)
                            {
                                Console.WriteLine("Your pet is thirsty. Press 1 to give it water.");
                                action = int.Parse(Console.ReadLine());
                                if (action == 1)
                                {
                                    Louie.PetWatering();
                                    Console.WriteLine("You have now given your pet water.");
                                }

                            }

                            else if (Louie.ThirstyStatus() == false)
                            {
                                Console.WriteLine("Your pet has enough water.");
                            }
                        }

                        else if (statusResponse == 3)
                        {
                            int action;
                            Console.WriteLine(Louie.SleepyStatus());
                            if (Louie.SleepyStatus() == true)
                            {
                                Console.WriteLine("Your pet is sleepy. Press 1 to give it a nap.");
                                action = int.Parse(Console.ReadLine());
                                if (action == 1)
                                {
                                    Louie.PetSleeping();
                                    Console.WriteLine("You have now given your pet a nap.");
                                }

                            }

                            else if (Louie.SleepyStatus() == false)
                            {
                                Console.WriteLine("Your pet has enough rest.");
                            }

                        }

                        else if (statusResponse == 4)
                        {
                            int action;
                            Console.WriteLine(Louie.HappyStatus());
                            if (Louie.HappyStatus() == true)
                            {
                                Console.WriteLine("Your pet is sad. Press 1 to play with it.");
                                action = int.Parse(Console.ReadLine());
                                if (action == 1)
                                {
                                    Louie.PetPlaying();
                                    Console.WriteLine("You have now played with your pet.");
                                }

                            }

                            else if (Louie.HappyStatus() == false)
                            {
                                Console.WriteLine("Your pet is happy!");
                            }
                        }
                    }

                    else if (response == 2)
                    {
                        Louie.PetPlaying();
                        Console.WriteLine("You have played with your pet.");
                    }

                    else if (response == 3)
                    {
                        Louie.Adoption();//I created a method, but I am not sure how to link the lists to it.
                    }

                    //else if (response == 4)//I have this section commented out, because I ran it, and it crashed, and I'm not sure why.
                    //{
                    //    Louie.PunchIn();
                    //    Console.WriteLine("You have added overtime for an employee.");
                    //}


                }

                if (menuResponseOne == 2)
                {
                    Console.WriteLine("Volunteer");
                    Console.WriteLine("Select 1 to check the status of a pet. Select 2 to play with one of the pets. /*Select 3 to sign up for overtime.*/");
                    int response = int.Parse(Console.ReadLine());
                    if (response == 1)
                    {

                        Console.WriteLine("Select 1 to check hunger status. Select 2 to check thirst status. Select 3 to check sleepiness status. Select 4 to check happiness status.");
                        int statusResponse = int.Parse(Console.ReadLine());
                        if (statusResponse == 1)
                        {
                            int action;
                            Console.WriteLine(Nikki.HungryStatus());
                            if (Nikki.HungryStatus() == true)
                            {
                                Console.WriteLine("Your pet is hungry. Press 1 to give it food.");
                                action = int.Parse(Console.ReadLine());
                                if (action == 1)
                                {
                                    Nikki.PetFeeding();
                                    Console.WriteLine("You have now given your pet food.");
                                }

                            }

                            else if (Nikki.HungryStatus() == false)
                            {
                                Console.WriteLine("Your pet has enough food.");
                            }


                            else if (statusResponse == 2)
                            {


                                Console.WriteLine(Nikki.ThirstyStatus());
                                if (Nikki.ThirstyStatus() == true)
                                {
                                    Console.WriteLine("Your pet is thirsty. Press 1 to give it water.");
                                    action = int.Parse(Console.ReadLine());
                                    if (action == 1)
                                    {
                                        Nikki.PetWatering();
                                        Console.WriteLine("You have now given your pet water.");
                                    }

                                }

                                else if (Nikki.ThirstyStatus() == false)
                                {
                                    Console.WriteLine("Your pet has enough water.");
                                }
                            }

                            else if (statusResponse == 3)
                            {

                                Console.WriteLine(Louie.SleepyStatus());
                                if (Nikki.SleepyStatus() == true)
                                {
                                    Console.WriteLine("Your pet is sleepy. Press 1 to give it a nap.");
                                    action = int.Parse(Console.ReadLine());
                                    if (action == 1)
                                    {
                                        Nikki.PetSleeping();
                                        Console.WriteLine("You have now given your pet a nap.");
                                    }

                                }

                                else if (Nikki.SleepyStatus() == false)
                                {
                                    Console.WriteLine("Your pet has enough rest.");
                                }
                            }

                            else if (statusResponse == 4)
                            {

                                Console.WriteLine(Louie.HappyStatus());
                                if (Nikki.HappyStatus() == true)
                                {

                                    Console.WriteLine("Your pet is sad. Press 1 to play with it.");
                                    action = int.Parse(Console.ReadLine());
                                    if (action == 1)
                                    {
                                        Nikki.PetPlaying();
                                        Console.WriteLine("You have now played with your pet.");
                                    }

                                }

                                else if (Nikki.HappyStatus() == false)
                                {
                                    Console.WriteLine("Your pet is happy!");
                                }
                            }



                        }
                    }


                    else if (response == 2)
                    {
                        Nikki.PetPlaying();
                        Console.WriteLine("You have played with your pet.");
                    }

                    //else if (response == 3)
                    //{
                    //    Nikki.PunchIn();
                    //    Console.WriteLine("You have signed up for overtime.");
                    //}

                }




            }
            Console.WriteLine("Thank you for visiting Bright Day Pet Shelter.");
            exitMain = "yes";

        }    

            
    }
}
