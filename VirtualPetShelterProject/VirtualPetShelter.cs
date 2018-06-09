using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelterProject
{
    class VirtualPetShelter
    {
        public string EmployeeOne { get; set; }
        public string EmployeeTwo { get; set; }
        public string ManagerOne { get; set; }
        public string ManagerTwo { get; set; }
        public string PetOne { get; set; }
        public string PetTwo { get; set; }

        public VirtualPetShelter(string employeeOne, string employeeTwo, string managerOne, string managerTwo, string petOne, string petTwo )
        {
            this.EmployeeOne = employeeOne;
            this.EmployeeTwo = employeeTwo;
            this.ManagerOne = managerOne;
            this.ManagerTwo = managerTwo;
            this.PetOne = petOne;
            this.PetTwo = petTwo;
        }


    }
}
